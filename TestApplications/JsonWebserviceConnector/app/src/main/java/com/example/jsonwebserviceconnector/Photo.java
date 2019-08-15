package com.example.jsonwebserviceconnector;

public class Photo {
    private String mTitle;
    private String mAuthor;
    private String mAutohrId;
    private String mLink;
    private String mTags;
    private String mImage;

    public Photo(String title, String author, String autohrId, String link, String tags, String image) {
        mTitle = title;
        mAuthor = author;
        mAutohrId = autohrId;
        mLink = link;
        mTags = tags;
        mImage = image;
    }

    String getTitle() {
        return mTitle;
    }

    String getAuthor() {
        return mAuthor;
    }

    String getAutohrId() {
        return mAutohrId;
    }

    String getLink() {
        return mLink;
    }

    String getTags() {
        return mTags;
    }

    String getImage() {
        return mImage;
    }

    @Override
    public String toString() {
        return "Photo{" +
                "mTitle='" + mTitle + '\'' +
                ", mAuthor='" + mAuthor + '\'' +
                ", mAutohrId='" + mAutohrId + '\'' +
                ", mLink='" + mLink + '\'' +
                ", mTags='" + mTags + '\'' +
                ", mImage='" + mImage + '\'' +
                '}';
    }
}
