package com.example.testshared;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ListView;

public class Auftragadapter extends BaseAdapter {
    private Context context;

    private ListView Auftraglist ;
    @Override
    public int getCount() {
        return Auftraglist.getCount();
    }

    @Override
    public Object getItem(int position) {
        return Auftraglist.getItemAtPosition(position);
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        ListView listview = new ListView(context);
        listview.setSelection(position);
        return  listview;
    }
}
