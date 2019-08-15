package com.example.testshared;

import android.content.Context;
import android.content.SharedPreferences;

public class Preconfigurationsave {

    Context context;
    SharedPreferences sharedPreferences;
    public Preconfigurationsave(Context _context){
        this.context =_context;
        sharedPreferences =context.getSharedPreferences(context.getResources().getString(R.string.app_pref_name),context.MODE_PRIVATE);
    }
    public void Writelogin(boolean status){
        SharedPreferences.Editor edit =sharedPreferences.edit();
        edit.putBoolean(context.getResources().getString(R.string.Pref_login_status_preference),status);
        edit.commit();
    }
    public boolean Readloginstatus(){
        boolean status =false;
        status =sharedPreferences.getBoolean(context.getResources().getString(R.string.Pref_login_status_preference),false);
        return status;
    }
    }


