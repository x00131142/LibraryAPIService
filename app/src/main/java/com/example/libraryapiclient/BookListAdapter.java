package com.example.libraryapiclient;

import android.content.Context;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;

public class BookListAdapter extends ArrayAdapter<Book> {
    private static final String TAG = "BookListAdapter";

    private int mResource;
    private int lastPosition = -1;
    private Context mContext;

    public BookListAdapter(Context context, int resource, ArrayList<Book> objects) {
        super(context, resource, objects);
        this.mContext = context;
        this.mResource = resource;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        String isbn = getItem(position).getISBN();
        String title = getItem(position).getTitle();
        String author = getItem(position).getAuthor();

        Book book = new Book(isbn,title,author);

        LayoutInflater inflater = LayoutInflater.from(mContext);
        convertView = inflater.inflate(mResource, parent, false);

        TextView tvISBN = (TextView) convertView.findViewById(R.id.textView1);
        TextView tvTitle = (TextView) convertView.findViewById(R.id.textView2);
        TextView tvAuthor = (TextView) convertView.findViewById(R.id.textView3);

        tvISBN.setText(isbn);
        tvAuthor.setText(author);
        tvTitle.setText(title);

        return convertView;
    }
}