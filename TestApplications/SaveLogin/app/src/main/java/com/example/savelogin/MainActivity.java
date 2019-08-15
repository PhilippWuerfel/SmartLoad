package com.example.savelogin;

import android.annotation.SuppressLint;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.res.Resources;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Toast;

import java.security.PrivateKey;

import io.paperdb.Paper;

public class MainActivity extends menu {

    private static final String TAG = "MainActivity";
    private  EditText etpassforgot;
    private Button btnLogin;
    private EditText etWebserverLink;
    public Boolean saveLogin;
    private String username;
    private   String password;
    private EditText etName;
    private EditText etPassword;
    private CheckBox cbLogin;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        cbLogin =(CheckBox)findViewById(R.id.cbLogin);
        etName =(EditText)findViewById(R.id.etName);
        etPassword =(EditText)findViewById(R.id.etPassword);
        btnLogin =(Button)findViewById(R.id.btnLogin);
        etpassforgot =(EditText)findViewById(R.id.etforgotpassword);
        sharedPreferences=getSharedPreferences(name_pref,MODE_PRIVATE);
        editor=sharedPreferences.edit();
        saveLogin=sharedPreferences.getBoolean("saveLogin",false);
        if(saveLogin==true){
            etName.setText(sharedPreferences.getString("username",null));
            etPassword.setText(sharedPreferences.getString("password",null));
            cbLogin.setChecked(true);
        }
        else if (saveLogin==false){
            saveLogin=sharedPreferences.getBoolean("saveLogin",false);
                etName.setText("",null);
                etPassword.setText("",null);
        }

       btnLogin.setOnClickListener(new View.OnClickListener() {
           @Override
           public void onClick(View view) {
               Login();
               Intent intent_Menuactivity =new Intent(MainActivity.this,MenuActivity.class) ;
               startActivity(intent_Menuactivity);
           }
       });

    }


    void Login (){
         username=etName.getText().toString();
         password =etPassword.getText().toString();
        if(username.equals("Brice")&&password.equals("123344")){
            Toast.makeText(this, "Welcome "+username +" "+ password, Toast.LENGTH_SHORT).show();
            if (cbLogin.isChecked()){
                editor.putString("username",username);
                editor.putString("password",password);
                editor.putBoolean("saveLogin",true);
                editor.apply();
            }
        }
        else{

            Toast.makeText(this, "Welcome "+username +" "+ password, Toast.LENGTH_SHORT).show();
        }
    }
}
