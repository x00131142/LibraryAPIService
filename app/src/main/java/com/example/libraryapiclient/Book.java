package com.example.libraryapiclient;

import java.util.Date;

public class Book {
    private String ISBN;
    private String Title;
    private String Author;
    private String Publisher;
    private Date releaseDate;

    public Book() {
    }

    public Book(String ISBN, String title, String author, String publisher, Date releaseDate) {
        this.ISBN = ISBN;
        Title = title;
        Author = author;
        Publisher = publisher;
        this.releaseDate = releaseDate;
    }

    public Book(String ISBN, String title, String author) {
        this.ISBN = ISBN;
        Title = title;
        Author = author;
    }

    public String getISBN() {
        return ISBN;
    }

    public void setISBN(String ISBN) {
        this.ISBN = ISBN;
    }

    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    public String getAuthor() {
        return Author;
    }

    public void setAuthor(String author) {
        Author = author;
    }

    public String getPublisher() {
        return Publisher;
    }

    public void setPublisher(String publisher) {
        Publisher = publisher;
    }

    public Date getReleaseDate() {
        return releaseDate;
    }

    public void setReleaseDate(Date releaseDate) {
        this.releaseDate = releaseDate;
    }
}
