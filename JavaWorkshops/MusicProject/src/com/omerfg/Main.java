package com.omerfg;

import com.omerfg.model.DataSource;
import com.omerfg.model.Singer;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        DataSource dataSource = new DataSource();
        dataSource.openDatabase();
        ArrayList<Singer> allSinger= dataSource.showAllSinger(DataSource.decrease);
        if (allSinger ==null){
            System.out.println("No Singer");
            return;
        }
        for (Singer s : allSinger)
            System.out.println(s.getSingerID() +" " + s.getSingerName());
        dataSource.closeDatabase();
    }
}
