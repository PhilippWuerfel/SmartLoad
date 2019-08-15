package com.example.testshared;

import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private  Preconfigurationsave prefconfig;
    private Button btnlogin;
    private EditText username ,password;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        prefconfig= new Preconfigurationsave(getApplicationContext());

        username =findViewById(R.id.etName);
        password =findViewById(R.id.etPassword);
        btnlogin =findViewById(R.id.btnLogin);
        if (prefconfig.Readloginstatus()){
            startActivity(new Intent(this,Sucess.class));
        }
        btnlogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
            valide(username.getText().toString());
            }
        });


    }
    public void valide( String user){
        if(user.equals("Packer"))
        {
            // Intent MainActivity to Landing Page of Driver
            startActivity(new Intent( this,Sucess.class));
            prefconfig.Writelogin(true);
            finishAffinity();

        }
    else{
        username.setText("");
        displaymessage("Please enter a valid ID or password!");
    }
    }

    public  void displaymessage(String message){
        Toast.makeText(MainActivity.this,message, Toast.LENGTH_LONG).show();
    }
}
