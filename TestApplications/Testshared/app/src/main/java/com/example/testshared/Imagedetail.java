package com.example.testshared;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.ImageView;

public class Imagedetail extends AppCompatActivity {
    private  Preconfigurationsave prefsucess1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_imagedetail);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction(" Action", null).show();
            }
        });
        Intent i = getIntent();

        int position = i.getExtras().getInt("id");
        ImageAdapter imageAdapter =new ImageAdapter(this);
        ImageView imageView =findViewById(R.id.imageView);
        imageView.setImageResource(imageAdapter.Image[position]);

        prefsucess1 = new Preconfigurationsave(getApplicationContext());
    }

}
