package com.example.libraryapiclient;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.google.gson.Gson;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private static final String TAG = "MainActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final RequestQueue queue = Volley.newRequestQueue(this);
        final String url = "https://libraryserviceapi.azurewebsites.net/api/book";
        final TextView tvBook = (TextView) findViewById(R.id.bookView);
        final Gson gson = new Gson();
        Button searchBtn = (Button) findViewById(R.id.searchBtn);

        searchBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                TextView tvQuery = (TextView) findViewById(R.id.editText);
                //String queryStr =  url + (String) tvQuery.getText();


                // Request a string response from the provided URL.
                StringRequest stringRequest = new StringRequest(Request.Method.GET, url,
                        new Response.Listener<String>() {
                        @Override
                        public void onResponse(String response) {
                            try {
                                JSONArray jArr = new JSONArray(response);
                                tvBook.setText(response);

                                } catch (JSONException e) {
                                    e.printStackTrace();
                                tvBook.setText("That didn't work!");
                                }


                            // Display the first 500 characters of the response string.
                            //gson.fromJson(response, Book.class);
                            tvBook.setText(response);
                        }
                        }, new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        tvBook.setText("That didn't work!SDFSD");
                    }
                });

                queue.add(stringRequest);
            }
        });

        Log.d(TAG, "onCreate: Started.");


        //ListView mListView = (ListView) findViewById(R.id.bookView);


        Book bookTest = new Book("dsfsdfsd","asdsdfsd","James");
        final ArrayList<Book> bookList = new ArrayList<>();
        bookList.add(bookTest);



        //final ListView listView = (ListView) findViewById(R.id.bookView);






        //BookListAdapter adapter = new BookListAdapter(this, R.layout.adapter_view_layout, bookList);
        //mListView.setAdapter(adapter);
    }
}