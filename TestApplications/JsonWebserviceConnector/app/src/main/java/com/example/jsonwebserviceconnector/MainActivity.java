package com.example.jsonwebserviceconnector;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;

import java.util.List;

public class MainActivity extends AppCompatActivity implements GetRawData.OnDownloadComplete, GetFlickrJsonData.OnDataAvailable {
    private static final String TAG = "MainActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Log.d(TAG, "onCreate: starts");
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        // Test downloading JSON Data
        GetRawData getRawData = new GetRawData(this);
//        getRawData.execute("https://api.flickr.com/services/feeds/photos_public.gne?tags=android,nougat,sdk&tagmode=any&format=json&nojsoncallback=?");
//        getRawData.execute("http://rs.bss-bln.de/");
//        getRawData.execute("https://jsonplaceholder.typicode.com/todos/");
        getRawData.execute("http://localhost:16005/api/Todo");


        Log.d(TAG, "onCreate: ends");
    }

    @Override
    protected void onResume() {
        Log.d(TAG, "onResume starts");
        super.onResume();
        GetFlickrJsonData getFlickrJsonData = new GetFlickrJsonData(this,
                "https://api.flickr.com/services/feeds/photos_public.gne",
                "en-us", true);
        // call on same thread
//        getFlickrJsonData.executeOnSameThread("android, nougat");
        // call as Asynctask
        getFlickrJsonData.execute("HTW, Berlin");

        Log.d(TAG, "onResume ends");
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        Log.d(TAG, "onCreateOptionsMenu() returned: " + true);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    // check if Download completed (callback) --> From interface in GetRawData
    // Only necessary if Class GetRawData used (for testing)
    // normally only Class GetFlickrJsonData necessary (will use GetRawData inside)
    @Override
    public void onDownloadComplete(String data, DownloadStatus status){
        if(status==DownloadStatus.OK){
            Log.d(TAG, "onDownloadComplete: data is " + data);
        }else{
            // download processing failed
            Log.e(TAG, "onDownloadComplete failed with status " + status );
        }
    }

    // check if Data available (callback) --> From interface in GetFlickrJsonData
    @Override
    public void onDataAvailable(List<Photo> data, DownloadStatus status) {
        if (status == DownloadStatus.OK){
            Log.d(TAG, "onDataAvailable: data is " + data);
        }else{
            Log.e(TAG, "onDataAvailable failed with status " + status);
        }
    }
}
