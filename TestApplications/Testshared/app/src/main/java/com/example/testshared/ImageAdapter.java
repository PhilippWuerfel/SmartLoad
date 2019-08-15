package com.example.testshared;

import android.content.Context;
import android.media.Image;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.GridLayout;
import android.widget.GridView;
import android.widget.ImageView;

import java.util.List;

public class ImageAdapter extends BaseAdapter {

    private Context context;

    public ImageAdapter(Context c){
        context =c;
    }
    public Integer [] Image ={
            R.drawable.pic_1,R.drawable.pic_2
    };
    @Override
    public int getCount() {
        return Image.length;
    }

    @Override
    public Object getItem(int position) {
        return Image[position];
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        ImageView imageView = new ImageView(context);
        imageView.setImageResource(Image[position]);
        imageView.setScaleType(ImageView.ScaleType.FIT_CENTER);
        imageView.setLayoutParams( new GridView.LayoutParams(300,300));
        return imageView;
    }
}

