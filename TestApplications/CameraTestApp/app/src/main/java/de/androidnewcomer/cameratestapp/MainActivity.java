package de.androidnewcomer.cameratestapp;

import android.Manifest;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Build;
import android.os.Environment;
import android.provider.MediaStore;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.support.v4.content.FileProvider;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

import java.io.File;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class MainActivity extends AppCompatActivity {

    Button btnPhoto;
    ImageView imageView;
    File photoFile;
    String currentPhotoPath;
    Uri photoURI;
    static final int CAPTURE_IMAGE_REQUEST=1;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnPhoto=findViewById(R.id.btnPhoto);
        imageView=findViewById(R.id.imageView);

        btnPhoto.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(ContextCompat.checkSelfPermission(MainActivity.this, Manifest.permission.CAMERA)!= PackageManager.PERMISSION_GRANTED){
                    ActivityCompat.requestPermissions(MainActivity.this,new String[]{Manifest.permission.CAMERA,Manifest.permission.WRITE_EXTERNAL_STORAGE},0);
                }

                captureImage();
            }
        });
    }

    private void captureImage() {
        if(ContextCompat.checkSelfPermission(MainActivity.this, Manifest.permission.CAMERA)!= PackageManager.PERMISSION_GRANTED){
            ActivityCompat.requestPermissions(MainActivity.this,new String[]{Manifest.permission.CAMERA,Manifest.permission.WRITE_EXTERNAL_STORAGE},0);
        }
        else{
        Intent takePhotoIntent= new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
        //startActivityForResult(takePhotoIntent,CAPTURE_IMAGE_REQUEST);
            if(takePhotoIntent.resolveActivity(getPackageManager())!=null){
                try {
                    photoFile=createImageFile();
                    displayMessage(getBaseContext(),photoFile.getAbsolutePath());

                    if(photoFile!=null){
                        photoURI= FileProvider.getUriForFile(this,"de.androidnewcomer.cameratestapp.fileprovider",photoFile);
                        takePhotoIntent.putExtra(MediaStore.EXTRA_OUTPUT,photoURI);
                        startActivityForResult(takePhotoIntent,CAPTURE_IMAGE_REQUEST);
                    }

                }
                catch (Exception e){
                    displayMessage(getBaseContext(),e.getMessage());
                }
            }
        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {

        if(requestCode==CAPTURE_IMAGE_REQUEST && resultCode==RESULT_OK){
            Bitmap myBitmap= BitmapFactory.decodeFile(photoFile.getAbsolutePath());
            imageView.setImageBitmap(myBitmap);
        }
        /*Bundle extras=data.getExtras();
        Bitmap image=(Bitmap)extras.get("data");
        imageView.setImageBitmap(image);*/
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        if(requestCode==0){
            if(grantResults.length>0 && grantResults[0]==PackageManager.PERMISSION_GRANTED && grantResults[1]==PackageManager.PERMISSION_GRANTED){
                captureImage();
            }
            else {
                displayMessage(getBaseContext(),"This app doesnt work without camera permission");
            }


        }

    }

    private File createImageFile() throws IOException{
        String timeStamp= new SimpleDateFormat("yyyyMMdd_HHmmss").format(new Date());
        String imageFileName="JPG_"+timeStamp+"_";
        File storageDir=getExternalFilesDir(Environment.DIRECTORY_PICTURES);
        File image= File.createTempFile(imageFileName,".jpg",storageDir);
        currentPhotoPath=image.getAbsolutePath();
        return image;
    }

    private void displayMessage(Context context, String message){
        Toast.makeText(context,message,Toast.LENGTH_LONG).show();
    }
}
