package com.example.dmt22114assignment1;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import java.text.DecimalFormat;

public class MainActivity extends AppCompatActivity {
    Spinner option;
    Button convert;
    Button clear;
    TextView title;
    TextView result;
    EditText inputText;
    int selected;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        option = findViewById(R.id.selection);
        convert = findViewById(R.id.buttonConvert);
        clear = findViewById(R.id.buttonClear);
        title = findViewById(R.id.titleDisplay);
        result = findViewById(R.id.showresult);
        inputText = findViewById(R.id.input);

        Option();
        Convert();
        Clear();

    }

    private void Convert() {
        convert.setOnClickListener(new View.OnClickListener() {
            @SuppressLint("SetTextI18n")
            @Override
            public void onClick(View view) {

                try {
                    Double temperature;
                    temperature = Double.parseDouble(String.valueOf(inputText.getText()));

                    if(selected == 0) {
                        temperature = temperature  * 9 / 5 + 32;
                        temperature = Double.parseDouble(new DecimalFormat("##.###").format(temperature));
                        result.setText(temperature + " °F");
                    }
                    else if(selected == 1) {
                        temperature = temperature + 273;
                        temperature = Double.parseDouble(new DecimalFormat("##.###").format(temperature));
                        result.setText(temperature + " K");
                    }
                    else if(selected == 2) {
                        temperature = (temperature - 273) * 9 / 5 + 32;
                        temperature = Double.parseDouble(new DecimalFormat("##.###").format(temperature));
                        result.setText(temperature + " °F");
                    }
                    else if(selected == 3) {
                        temperature = temperature - 273;
                        temperature = Double.parseDouble(new DecimalFormat("##.###").format(temperature));
                        result.setText(temperature + " °C");
                    }
                    else if(selected == 4) {
                        temperature = (temperature - 32) * 5 / 9;
                        temperature = Double.parseDouble(new DecimalFormat("##.###").format(temperature));
                        result.setText(temperature + " °C");
                    }
                    else if(selected == 5) {
                        temperature = (temperature - 32) * 5 / 9 + 273;
                        temperature = Double.parseDouble(new DecimalFormat("##.###").format(temperature));
                        result.setText(temperature + " K");
                    }
                }catch(NumberFormatException e) {
                    e.printStackTrace();
                }
            }
        });
    }

    private void Clear() {
        clear.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                option.setSelection(0);
                result.setText("0.0");
                inputText.setText("");
            }
        });
    }


    private void Option() {
        option.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                selected = i;
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });
    }
}


