package Database;

import java.sql.*;

public class UseDatabase {
    public static void main(String[] args) {
        try (Connection connection = DriverManager.getConnection("jdbc:sqlite:test.db");
             Statement statement = connection.createStatement();
        ){
            //satabase yoksa olusturulacak.
            connection.setAutoCommit(false);
            statement.execute("CREATE TABLE IF NOT EXISTS users(name TEXT,email TEXT)");
            statement.execute("INSERT INTO users(name,email)VALUES ('OMER','bayomerfg@gmail.com')");
            statement.execute("UPDATE users SET name ='fg' where name = 'OMER'");
            int changingColumnsCount = statement.executeUpdate("UPDATE users SET name ='fga' where name = 'fg'");
            //iki update sorgusuda aslinda aynidir ancak birisi etkkilenen deger sayisini doner.
            //statement.execute("delete from users");
            System.out.println(changingColumnsCount);
            connection.commit();
            ResultSet resultSet=statement.executeQuery("SELECT * FROM users");
            while(resultSet.next()){
                System.out.println(resultSet.getString(1)+" " + resultSet.getString("email"));
                //sutun indexleri 0 dan degil 1 den baslar.
            }
            PreparedStatement preparedStatement = connection.prepareStatement("select * from users where name = ?"); //kosullu hazirlanan sorgudur buu.
            //soru isareti yerine kendi degerlerini atayabilirsin. 1. soru isareti yerine fga koyduk
            preparedStatement.setString(1,"fga");
            resultSet = preparedStatement.executeQuery();
            while (resultSet.next()){
                System.out.println(resultSet.getString(1)+" " + resultSet.getString("email"));
            }
        }catch (SQLException e){
            e.printStackTrace();
        }
    }
}
