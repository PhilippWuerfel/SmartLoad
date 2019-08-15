package com.example.savelogin;

import android.annotation.SuppressLint;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.res.Resources;
import android.os.Bundle;
import android.os.Environment;
import android.support.v7.app.AppCompatActivity;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;

import java.io.File;
import java.util.ArrayList;

import io.paperdb.Paper;

public class menu extends AppCompatActivity {
    public SharedPreferences sharedPreferences;
    public SharedPreferences.Editor editor;
    public Boolean saveLogin;
    public String name_pref;


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater=getMenuInflater();
        getMenuInflater().inflate(R.menu.option,menu);
        sharedPreferences=getSharedPreferences(name_pref,MODE_PRIVATE);
        editor=sharedPreferences.edit();
        return true;
    }
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {

         if(item.getItemId()==R.id.Logout){
             editor.putString("",null);
             editor.putString("",null);
             editor.putBoolean("saveLogin",false);
             editor.apply();
             Intent intent_Menuactivity =new Intent(this,MainActivity.class) ;
             startActivity(intent_Menuactivity);
             //deleteAllFile();
        }
        return true;
    }

    /*private void deleteAllFile(){
        File filepath = Environment.getExternalStorageDirectory();
        File folder = new File(filepath.getAbsolutePath() + "/SaveLogin/");
        File[] listOfFiles = folder.listFiles();

        for (int i = 0; i < listOfFiles.length; i++) {
            if (listOfFiles[i].isFile()) {
                listOfFiles[i].delete();
            }
        }
    }*/
}
