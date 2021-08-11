package com.omerfg.model;

import java.sql.*;
import java.util.ArrayList;

public class DataSource {
    public static final String DB_NAME="Sing.db";
    public static final String CONNECTION_STRING ="jdbc:sqlite:"+DB_NAME;

    public static final String TABLE_ALBUM ="Album";
    public static final String COLUMN_ALBUMID ="AlbumID";
    public static final String COLUMN_ALBUMNAME ="AlbumName";
    public static final String COLUMN_ALBUM_SINGERID ="SingerID";

    public static final String TABLE_SINGER ="Singer";
    public static final String COLUMN_SINGERNAME ="SingerName";
    public static final String COLUMN_SINGERID ="SingerID";

    public static final String TABLE_SONG ="Song";
    public static final String COLUMN_SONGID ="SongID";
    public static final String COLUMN_SONGNAME ="SongName";
    public static final String COLUMN_SONG_ALBUUMID ="AlbumID";

    public static final int increase = 1;
    public static final int decrease = 2;

    private Connection connection;
    public boolean openDatabase(){
        try {
            connection = DriverManager.getConnection(CONNECTION_STRING);
            return true;
        } catch (SQLException e) {
            e.printStackTrace();
            return false;
        }

    }
    public void closeDatabase(){
        try{
            if (connection!=null){
                connection.close();
            }
        }catch (SQLException e){
            e.printStackTrace();
        }

    }
    public ArrayList<Singer> showAllSinger(int arrangement){
        StringBuilder stringBuilder = new StringBuilder("SELECT * FROM ");
        stringBuilder.append(TABLE_SINGER);

        if (arrangement == increase){
            stringBuilder.append(" ORDER BY ");
            stringBuilder.append(COLUMN_SINGERNAME);
            stringBuilder.append(" ASC ");
        }else{
            stringBuilder.append(" ORDER BY ");
            stringBuilder.append(COLUMN_SINGERNAME);
            stringBuilder.append(" DESC ");
        }
        //isme gore sirali bir sekilde degerler gelir.
        try(Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery(stringBuilder.toString())){
            ArrayList<Singer> allSinger = new ArrayList<>();
            while (resultSet.next()){
                Singer singer = new Singer();
                singer.setSingerID(resultSet.getInt(COLUMN_SINGERID));
                singer.setSingerName(resultSet.getString(COLUMN_SINGERNAME));
                allSinger.add(singer);
            }
            return allSinger;
        }catch (SQLException e){
            System.out.println(e.getMessage());
            return  null;
        }
    }
}