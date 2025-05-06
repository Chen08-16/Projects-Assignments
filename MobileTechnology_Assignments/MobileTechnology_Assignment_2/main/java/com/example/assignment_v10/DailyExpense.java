package com.example.assignment_v10;

import java.io.Serializable;

public class DailyExpense implements Serializable {
    private String name;
    private String date;
    private int amount;
    private String types;
    private String meals;
    private int paymentOptions;
    private String description;

    ////////////////////////////////////////
    //Default Constructor                 //
    ////////////////////////////////////////
    public DailyExpense(){
        name = "Expenses ";
        date = "17/11/2021";
        amount = 0;
        types = "Food";
        meals = "Breakfast";
        paymentOptions = 0;
        description = "This is an example";
    }

    ////////////////////////////////////////
    //Constructor with Parameters         //
    ////////////////////////////////////////
    public DailyExpense(String name, String date, int amount, String types, String meals, int paymentOptions, String description) {
        this.name = name;
        this.date = date;
        this.amount = amount;
        this.types = types;
        this.meals = meals;
        this.paymentOptions = paymentOptions;
        this.description = description;
    }

    ////////////////////////////////////////
    //Getters                             //
    ////////////////////////////////////////
    public String getName(){
        return name;
    }
    public String getDate() {
        return date;
    }
    public int getAmount() {
        return amount;
    }
    public String getTypes() {
        return types;
    }
    public String getMeals() {
        return meals;
    }
    public int getPaymentOptions() {
        return paymentOptions;
    }
    public String getDescription() {
        return description;
    }

    ////////////////////////////////////////
    //Setters                             //
    ////////////////////////////////////////
    public void setName(String name){
        this.name = name;
    }
    public void setDate(String date) {
        this.date = date;
    }
    public void setAmount(int amount) {
        this.amount = amount;
    }
    public void setTypes(String types) {
        this.types = types;
    }
    public void setMeals(String meals) {
        this.meals = meals;
    }
    public void setPaymentOptions(int paymentOptions) {
        this.paymentOptions = paymentOptions;
    }
    public void setDescription(String description) {
        this.description = description;
    }

    ////////////////////////////////////////
    //Custom Methods                      //
    ////////////////////////////////////////
    @Override
    public String toString() {
        return name;//"Name: " + name + " Date: " + date;
    }
}
