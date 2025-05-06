package com.example.assignment_v10;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class UpdateDataActivity extends AppCompatActivity {
    private Spinner categorySelection1_update;
    private Spinner categorySelection2_update;

    private ArrayAdapter<CharSequence> adapterCategorySelection1;
    private ArrayAdapter<CharSequence> adapterCategorySelection2;

    private DailyExpense updateDailyExpense;

    public static final String UPDATE_DATA = "UPDATE DATA";
    public static final String DATA_POSITION = "DATA_POSITION";

    private EditText text_name_input_update;
    private EditText text_date_input_update;
    private EditText text_amount_input_update;
    private EditText text_Extra_Description_input_update;
    private RadioGroup radioGroup_update;
    private RadioButton radioButtonCash_update;
    private RadioButton radioButtonCredit_update;
    private RadioButton radioButtonMobile_update;

    private Button button_clear_update;
    private Button button_save_update;
    private Button button_back_update;

    String types;
    String meals;
    private int paymentOptions_update;
    private int position;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update_data);

        initialization();
        getDataFromMainActivity();
        loadSpinnerResources();

        radioButtonGroup();

        buttonEvents();

        loadData();
    }

    ////////////////////////////////////////
    //load and display data from the      //
    //MainActivity.java                   //
    ////////////////////////////////////////
    private void loadData() {
        String text = updateDailyExpense.getName();
        String date = updateDailyExpense.getDate();
        String amount = String.valueOf(updateDailyExpense.getAmount());
        String type_load = updateDailyExpense.getTypes();
        String meal_load = updateDailyExpense.getMeals();
        int paymentOptions = updateDailyExpense.getPaymentOptions();
        String description = updateDailyExpense.getDescription();

        text_name_input_update.setText(text);
        text_date_input_update.setText(date);
        text_amount_input_update.setText(amount);

        int categorySelection1Position = adapterCategorySelection1.getPosition(type_load);
        int categorySelection2Position = adapterCategorySelection2.getPosition(meal_load);

        categorySelection1_update.setSelection(categorySelection1Position);
        categorySelection2_update.setSelection(categorySelection2Position);

        if(paymentOptions == 1){//changed
            radioGroup_update.check(R.id.radioButton_cash_update);
        }
        else if(paymentOptions == 2){//changed
            radioGroup_update.check(R.id.radioButton_credit_update);
        }
        else if(paymentOptions == 3){//changed
            radioGroup_update.check(R.id.radioButton_mobile_update);
        }

        text_Extra_Description_input_update.setText(description);
    }

    ////////////////////////////////////////
    //Initialize all variables            //
    ////////////////////////////////////////
    private void initialization() {
        categorySelection1_update = findViewById(R.id.categorySelection_update);
        categorySelection2_update = findViewById(R.id.categorySelection2_update);

        text_name_input_update = findViewById(R.id.text_name_input_update);
        text_date_input_update = findViewById(R.id.text_date_input_update);
        text_amount_input_update = findViewById(R.id.text_amount_input_update);
        text_Extra_Description_input_update = findViewById(R.id.text_Extra_Description_input_update);

        radioGroup_update = findViewById(R.id.paymentSelection_update);
        radioButtonCash_update = findViewById(R.id.radioButton_cash_update);
        radioButtonCredit_update = findViewById(R.id.radioButton_credit_update);
        radioButtonMobile_update = findViewById(R.id.radioButton_mobile_update);

        button_clear_update = findViewById(R.id.button_clear_update);
        button_save_update = findViewById(R.id.button_save_update);
        button_back_update = findViewById(R.id.button_back_update);
    }

    ////////////////////////////////////////
    //get data from the MainActivity.java //
    ////////////////////////////////////////
    private void getDataFromMainActivity(){
        Intent intentGet = getIntent();
        //count = intentGet.getIntExtra(MainActivity.SET_EXPENSE_COUNT, 1);// delete it
        updateDailyExpense = (DailyExpense)intentGet.getSerializableExtra(MainActivity.DATA_UPDATE); //get and extract the data from MainActivity.java

        position = intentGet.getIntExtra(MainActivity.DATA_POSITION, 0);//new
    }

    ////////////////////////////////////////
    //Load Data for Spinner Function      //
    ////////////////////////////////////////
    private void loadSpinnerResources() {
        adapterCategorySelection1 = ArrayAdapter.createFromResource(this, R.array.category_selection1, android.R.layout.simple_spinner_item);
        adapterCategorySelection2 = ArrayAdapter.createFromResource(this, R.array.category_selection2, android.R.layout.simple_spinner_item);

        adapterCategorySelection1.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        adapterCategorySelection2.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        categorySelection1_update.setAdapter(adapterCategorySelection1);
        categorySelection2_update.setAdapter(adapterCategorySelection2);
    }

    ////////////////////////////////////////
    //Control Radio Group Events          //
    ////////////////////////////////////////
    private void radioButtonGroup(){
        radioGroup_update.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                switch(checkedId){
                    case R.id.radioButton_cash_update:
                        paymentOptions_update = 1;
                        break;
                    case R.id.radioButton_credit_update:
                        paymentOptions_update = 2;
                        break;
                    case R.id.radioButton_mobile_update:
                        paymentOptions_update = 3;
                        break;
                    default:
                        break;
                }
            }
        });
    }

    ////////////////////////////////////////
    //Control Buttons Events              //
    ////////////////////////////////////////
    private void buttonEvents(){
        //perform clear button function
        button_clear_update.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                text_name_input_update.setText("");
                text_date_input_update.setText("");
                text_amount_input_update.setText("");

                //Set payment as Cash in radio button by default
                radioGroup_update.check(R.id.radioButton_cash);

                //Set category to the first categories
                categorySelection1_update.setSelection(0);
                categorySelection2_update.setSelection(0);

                text_Extra_Description_input_update.setText("");
            }
        });

        //perform save button function
        button_save_update.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    String name = text_name_input_update.getText().toString();//"Expenses " + count;
                    String date = text_date_input_update.getText().toString();
                    int amount = Integer.parseInt(text_amount_input_update.getText().toString());
                    String description = text_Extra_Description_input_update.getText().toString();

                    types = categorySelection1_update.getSelectedItem().toString();
                    meals = categorySelection2_update.getSelectedItem().toString();

                    if(radioButtonCash_update.isChecked() == true){
                        paymentOptions_update = 1;
                    }
                    if(name.isEmpty()){
                        Toast.makeText(UpdateDataActivity.this, "Please Enter Name in Expense Name Section", Toast.LENGTH_SHORT).show();
                        return;//Terminated if name is empty and will not run the code below in this function
                    }
                    if(date.isEmpty()){
                        Toast.makeText(UpdateDataActivity.this, "Please Enter Date in Expense Date Section", Toast.LENGTH_SHORT).show();
                        return;//Terminated if date is empty and will not run the code below in this function
                    }

                    updateDailyExpense = new DailyExpense(name, date, amount, types, meals, paymentOptions_update, description);

                    Intent returnIntent = new Intent(getApplicationContext(), MainActivity.class);
                    returnIntent.putExtra(UPDATE_DATA, updateDailyExpense);
                    //returnIntent.putExtra(MODIFIED_EXPENSE_COUNT, 1);
                    returnIntent.putExtra(DATA_POSITION, position);//new
                    setResult(RESULT_OK, returnIntent);
                }
                catch(NumberFormatException e){
                    Toast.makeText(UpdateDataActivity.this, "Please Enter Valid Number in Amount Section", Toast.LENGTH_SHORT).show();
                    return;//Terminated if get NumberFormatException and will not execute finish(); function
                }
                finish();
            }
        });

        //perform back button function
        button_back_update.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }

}
