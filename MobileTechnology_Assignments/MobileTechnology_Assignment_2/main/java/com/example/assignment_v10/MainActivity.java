package com.example.assignment_v10;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.activity.result.ActivityResult;
import androidx.activity.result.ActivityResultCallback;
import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.os.Parcelable;
import android.util.SparseArray;
import android.view.View;

import android.view.Menu;
import android.view.MenuItem;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private ListView list_dailyExpense;
    private ArrayList<DailyExpense> dailyExpenseArrayListDatabase;

    private ArrayList<String> dailyExpenseList = new ArrayList<>();
    private ArrayAdapter<String> adapter;

    ActivityResultLauncher<Intent> startForAddResult;
    ActivityResultLauncher<Intent> startForUpdateResult;
    ActivityResultLauncher<Intent> startForDeleteResult;

    public static final String DATA_UPDATE = "DATA_UPDATE";
    public static final String DATA_POSITION = "DATA_POSITION";
    public static final String DATA_DELETE = "DATA_DELETE";

    private int expenseCount = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        list_dailyExpense = findViewById(R.id.list_dailyExpense);

        loadDatabase();
        reloadDailyExpenseList();

        adapter = new ArrayAdapter<>(this, R.layout.list_item, R.id.TextView, dailyExpenseList);

        list_dailyExpense.setAdapter(adapter);

        //Return the data from AddDataActivity
        startForAddResult =
                registerForActivityResult(new ActivityResultContracts.StartActivityForResult(),
                        new ActivityResultCallback<ActivityResult>() {
                            @Override
                            public void onActivityResult(ActivityResult result) {
                                if(result.getResultCode() == Activity.RESULT_OK){
                                    Intent intent = result.getData();

                                    dailyExpenseArrayListDatabase.add((DailyExpense)intent.getSerializableExtra(AddDataActivity.ADD_DATA));//crash here!

                                    dailyExpenseList.clear();
                                    reloadDailyExpenseList();
                                    adapter.notifyDataSetChanged();

                                    //Toast.makeText(getApplicationContext(), expenseCount, Toast.LENGTH_SHORT).show();
                                }
                            }
                        }
                );

        //Return the data from UpdateDataActivity
        startForUpdateResult =
                registerForActivityResult(new ActivityResultContracts.StartActivityForResult(),
                        new ActivityResultCallback<ActivityResult>() {
                            @Override
                            public void onActivityResult(ActivityResult result) {
                                if(result.getResultCode() == Activity.RESULT_OK) {//new
                                    Intent intent = result.getData();//new

                                    int position = intent.getIntExtra(UpdateDataActivity.DATA_POSITION, 0);//new

                                    dailyExpenseArrayListDatabase.set(position, (DailyExpense) intent.getSerializableExtra(UpdateDataActivity.UPDATE_DATA));//new

                                    dailyExpenseList.clear();
                                    reloadDailyExpenseList();
                                    adapter.notifyDataSetChanged();
                                }
                            }
                });

        //Just a references use only
        startForDeleteResult =
                registerForActivityResult(new ActivityResultContracts.StartActivityForResult(),
                        new ActivityResultCallback<ActivityResult>() {
                            @Override
                            public void onActivityResult(ActivityResult result) {

                            }
                });

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Create the intent
                Intent intent = new Intent(getApplicationContext(), AddDataActivity.class);
                startForAddResult.launch(intent);
            }
        });

        list_dailyExpense.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long l) {
                updateData(position);
            }
        });

        list_dailyExpense.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
                final int which_item = position;

                new AlertDialog.Builder(MainActivity.this)
                        .setIcon(android.R.drawable.ic_delete)
                        .setTitle("Are you sure about it?")
                        .setMessage("Confirm to delete this expense?")
                        .setPositiveButton("Yes", new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {
                                dailyExpenseArrayListDatabase.remove(which_item);
                                adapter.notifyDataSetInvalidated();

                                dailyExpenseList.clear();
                                reloadDailyExpenseList();
                            }
                        })
                        .setNegativeButton("No", null)
                        .show();
                return true;
            }
        });
    }

    @Override
    protected void onSaveInstanceState(@NonNull Bundle outState){
        //super.onSaveInstanceState(outState);
        //Save the existing content inside the bundle
        outState.putSerializable("DATA_SAVE", dailyExpenseArrayListDatabase);
        super.onSaveInstanceState(outState);
    }

    @Override
    protected void onRestoreInstanceState(Bundle savedInstanceState){
        //Restore the data
        if(savedInstanceState != null){
            if(savedInstanceState.containsKey("DATA_SAVE")){
                dailyExpenseArrayListDatabase = (ArrayList<DailyExpense>)savedInstanceState.getSerializable("DATA_SAVE");

                //Toast.makeText(MainActivity.this, "Data loaded!", Toast.LENGTH_SHORT).show();
            }
        }
        super.onRestoreInstanceState(savedInstanceState);
    }

    public void updateData(int position){
        Intent intent = new Intent(getApplicationContext(),UpdateDataActivity.class);
        DailyExpense updateDailyExpense = new DailyExpense(
                dailyExpenseArrayListDatabase.get(position).getName(),
                dailyExpenseArrayListDatabase.get(position).getDate(),
                dailyExpenseArrayListDatabase.get(position).getAmount(),
                dailyExpenseArrayListDatabase.get(position).getTypes(),
                dailyExpenseArrayListDatabase.get(position).getMeals(),
                dailyExpenseArrayListDatabase.get(position).getPaymentOptions(),
                dailyExpenseArrayListDatabase.get(position).getDescription()
        );
        intent.putExtra(DATA_UPDATE, updateDailyExpense);
        intent.putExtra(DATA_POSITION, position);
        startForUpdateResult.launch(intent);
    }

    public void loadDatabase(){
        dailyExpenseArrayListDatabase = new ArrayList<DailyExpense>(0);//This line of code must be include in order to avoid NullPointerException

        //dailyExpenseArrayListDatabase.add(new DailyExpense("Expense 1", "17/11/2021", 0, "Food", "Breakfast", 0, "This is an example")); //test
    }

    public void reloadDailyExpenseList(){
        for(DailyExpense daily:dailyExpenseArrayListDatabase){
            dailyExpenseList.add(daily.toString());
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_add){
            Intent intent = new Intent(getApplicationContext(), AddDataActivity.class);
            startForAddResult.launch(intent);
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}