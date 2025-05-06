package com.example.assignment_v10;

import androidx.appcompat.app.AppCompatActivity;

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

public class AddDataActivity extends AppCompatActivity {

    private Spinner categorySelection1;
    private Spinner categorySelection2;

    private ArrayAdapter<CharSequence> adapterCategorySelection1;
    private ArrayAdapter<CharSequence> adapterCategorySelection2;

    private DailyExpense addDailyExpense;

    public static final String ADD_DATA = "ADD DATA";

    private EditText text_name_input;
    private EditText text_date_input;
    private EditText text_amount_input;
    private EditText text_Extra_Description_input;
    private RadioGroup radioGroup;
    private RadioButton radioButtonCash;
    private RadioButton radioButtonCredit;
    private RadioButton radioButtonMobile;

    private Button button_clear;
    private Button button_save;
    private Button button_back;

    int count;
    String types;
    String meals;
    private int paymentOptions;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_data);

        initialization();
        getDataFromMainActivity();
        loadSpinnerResources();

        radioButtonGroup();

        buttonEvents();
    }

    ////////////////////////////////////////
    //Initialize all variables            //
    ////////////////////////////////////////
    private void initialization() {
        categorySelection1 = findViewById(R.id.categorySelection);
        categorySelection2 = findViewById(R.id.categorySelection2);

        text_name_input = findViewById(R.id.text_name_input);
        text_date_input = findViewById(R.id.text_date_input);
        text_amount_input = findViewById(R.id.text_amount_input);
        text_Extra_Description_input = findViewById(R.id.text_Extra_Description_input);

        radioGroup = findViewById(R.id.paymentSelection);

        radioButtonCash = findViewById(R.id.radioButton_cash);
        radioButtonCredit = findViewById(R.id.radioButton_credit);
        radioButtonMobile = findViewById(R.id.radioButton_mobile);

        button_clear = findViewById(R.id.button_clear);
        button_save = findViewById(R.id.button_save);
        button_back = findViewById(R.id.button_back);
    }

    ////////////////////////////////////////
    //get data from the MainActivity.java //
    ////////////////////////////////////////
    private void getDataFromMainActivity(){
        Intent intentGet = getIntent();
    } //just references purpose only

    ////////////////////////////////////////
    //Load Data for Spinner Function      //
    ////////////////////////////////////////
    private void loadSpinnerResources() {
        adapterCategorySelection1 = ArrayAdapter.createFromResource(this, R.array.category_selection1, android.R.layout.simple_spinner_item);
        adapterCategorySelection2 = ArrayAdapter.createFromResource(this, R.array.category_selection2, android.R.layout.simple_spinner_item);

        adapterCategorySelection1.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        adapterCategorySelection2.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        categorySelection1.setAdapter(adapterCategorySelection1);
        categorySelection2.setAdapter(adapterCategorySelection2);
    }

    ////////////////////////////////////////
    //Control Radio Group Events          //
    ////////////////////////////////////////
    private void radioButtonGroup(){
        radioGroup.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                switch(checkedId){
                    case R.id.radioButton_cash:
                        paymentOptions = 1;
                        break;
                    case R.id.radioButton_credit:
                        paymentOptions = 2;
                        break;
                    case R.id.radioButton_mobile:
                        paymentOptions = 3;
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
        button_clear.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                text_name_input.setText("");
                text_date_input.setText("");
                text_amount_input.setText("");

                //Set payment as Cash in radio button by default
                radioGroup.check(R.id.radioButton_cash);

                //Set category to the first categories
                categorySelection1.setSelection(0);
                categorySelection2.setSelection(0);

                text_Extra_Description_input.setText("");
            }
        });

        //perform save button function
        button_save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    String name = text_name_input.getText().toString();//"Expenses " + count;
                    String date = text_date_input.getText().toString();
                    int amount = Integer.parseInt(text_amount_input.getText().toString());
                    String description = text_Extra_Description_input.getText().toString();

                    types = categorySelection1.getSelectedItem().toString();
                    meals = categorySelection2.getSelectedItem().toString();

                    if(radioButtonCash.isChecked() == true){
                        paymentOptions = 1;
                    }
                    if(name.isEmpty()){
                        Toast.makeText(AddDataActivity.this, "Please Enter Name in Expense Name Section", Toast.LENGTH_SHORT).show();
                        return;//Terminated if name is empty and will not run the code below in this function
                    }
                    if(date.isEmpty()){
                        Toast.makeText(AddDataActivity.this, "Please Enter Date in Expense Date Section", Toast.LENGTH_SHORT).show();
                        return;//Terminated if date is empty and will not run the code below in this function
                    }

                    addDailyExpense = new DailyExpense(name, date, amount, types, meals, paymentOptions, description);

                    Intent returnIntent = new Intent(getApplicationContext(), MainActivity.class);
                    returnIntent.putExtra(ADD_DATA, addDailyExpense);
                    //returnIntent.putExtra(MODIFIED_EXPENSE_COUNT, 1);
                    setResult(RESULT_OK, returnIntent);
                }
                catch(NumberFormatException e){
                    Toast.makeText(AddDataActivity.this, "Please Enter Valid Number in Amount Section", Toast.LENGTH_SHORT).show();
                    return;//Terminated if get NumberFormatException and will not execute finish(); function
                }
                finish();
            }
        });

        //perform back button function
        button_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }
}