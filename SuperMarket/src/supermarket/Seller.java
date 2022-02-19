/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package supermarket;
import java.sql.DriverManager;
import java.sql.Connection;
import java.sql.PreparedStatement;
import javax.swing.JOptionPane;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.table.DefaultTableModel;
import net.proteanit.sql.DbUtils;

/**
 *
 * @author OmerFG
 */
public class Seller extends javax.swing.JFrame {

    /**
     * Creates new form Seller
     */
    public Seller() {
        initComponents();
        SelectSeller(); 
    }
    Connection Con = null;
    Statement statement = null;
    ResultSet resultSet = null;
    public void SelectSeller()
    {
       try{
            Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin");
            statement = Con.createStatement();
            resultSet = statement.executeQuery("Select * from SELLERTBL");
            SellerTbl.setModel(DbUtils.resultSetToTableModel(resultSet));
            Con.close();
       }catch(Exception e){
           
       }
       
    }
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        ExitLbl = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        SellerIDTB = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        SellerPasswordTB = new javax.swing.JTextField();
        jLabel8 = new javax.swing.JLabel();
        SellerNameTB = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        SellerGenderCB = new javax.swing.JComboBox<>();
        jLabel4 = new javax.swing.JLabel();
        ResetBtn = new javax.swing.JButton();
        AddBtn = new javax.swing.JButton();
        EditBtn = new javax.swing.JButton();
        DeleteBtn = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        SellerTbl = new javax.swing.JTable();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setUndecorated(true);

        jPanel1.setBackground(new java.awt.Color(255, 153, 0));
        jPanel1.setForeground(new java.awt.Color(255, 153, 0));

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));

        ExitLbl.setBackground(new java.awt.Color(255, 0, 0));
        ExitLbl.setFont(new java.awt.Font("Calibri", 1, 36)); // NOI18N
        ExitLbl.setForeground(new java.awt.Color(255, 0, 0));
        ExitLbl.setText("x");

        jLabel7.setBackground(new java.awt.Color(255, 153, 0));
        jLabel7.setFont(new java.awt.Font("Calibri", 1, 36)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(255, 153, 0));
        jLabel7.setText("MANAGE SELLER");

        SellerIDTB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        SellerIDTB.setForeground(new java.awt.Color(255, 153, 0));

        jLabel5.setBackground(new java.awt.Color(255, 153, 0));
        jLabel5.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(255, 153, 0));
        jLabel5.setText("SellerID");

        SellerPasswordTB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        SellerPasswordTB.setForeground(new java.awt.Color(255, 153, 0));

        jLabel8.setBackground(new java.awt.Color(255, 153, 0));
        jLabel8.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(255, 153, 0));
        jLabel8.setText("Password");

        SellerNameTB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        SellerNameTB.setForeground(new java.awt.Color(255, 153, 0));

        jLabel9.setBackground(new java.awt.Color(255, 153, 0));
        jLabel9.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(255, 153, 0));
        jLabel9.setText("Name");

        SellerGenderCB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        SellerGenderCB.setForeground(new java.awt.Color(255, 153, 0));
        SellerGenderCB.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Male", "Female", " " }));

        jLabel4.setBackground(new java.awt.Color(255, 153, 0));
        jLabel4.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(255, 153, 0));
        jLabel4.setText("Gender");

        ResetBtn.setBackground(new java.awt.Color(255, 153, 0));
        ResetBtn.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        ResetBtn.setText("Reset");
        ResetBtn.setBorder(null);
        ResetBtn.setBorderPainted(false);
        ResetBtn.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                ResetBtnMouseClicked(evt);
            }
        });

        AddBtn.setBackground(new java.awt.Color(255, 153, 0));
        AddBtn.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        AddBtn.setText("Add");
        AddBtn.setBorder(null);
        AddBtn.setBorderPainted(false);
        AddBtn.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                AddBtnMouseClicked(evt);
            }
        });

        EditBtn.setBackground(new java.awt.Color(255, 153, 0));
        EditBtn.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        EditBtn.setText("Edit");
        EditBtn.setBorder(null);
        EditBtn.setBorderPainted(false);
        EditBtn.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                EditBtnMouseClicked(evt);
            }
        });

        DeleteBtn.setBackground(new java.awt.Color(255, 153, 0));
        DeleteBtn.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        DeleteBtn.setText("Delete");
        DeleteBtn.setBorder(null);
        DeleteBtn.setBorderPainted(false);
        DeleteBtn.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                DeleteBtnMouseClicked(evt);
            }
        });

        SellerTbl.setFont(new java.awt.Font("Calibri", 1, 12)); // NOI18N
        SellerTbl.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "ID", "NAME", "PASSWORD", "GENDER"
            }
        ));
        SellerTbl.setRowHeight(18);
        SellerTbl.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                SellerTblMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(SellerTbl);

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGap(15, 15, 15)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel9)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(SellerNameTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel5)
                        .addGap(18, 18, 18)
                        .addComponent(SellerIDTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 109, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel8)
                        .addGap(18, 18, 18)
                        .addComponent(SellerPasswordTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel4)
                        .addGap(18, 18, 18)
                        .addComponent(SellerGenderCB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(45, 45, 45))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel7)
                        .addGap(270, 270, 270)
                        .addComponent(ExitLbl)
                        .addContainerGap())
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(AddBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(EditBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(26, 26, 26)
                        .addComponent(DeleteBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(26, 26, 26)
                        .addComponent(ResetBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(200, 200, 200))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 663, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(122, 122, 122))))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addComponent(ExitLbl)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGap(6, 6, 6)
                .addComponent(jLabel7)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(SellerIDTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(jLabel5)
                        .addComponent(jLabel8))
                    .addComponent(SellerPasswordTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(SellerGenderCB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4)
                    .addComponent(SellerNameTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel9))
                .addGap(11, 11, 11)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(AddBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(DeleteBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(ResetBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(EditBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 265, Short.MAX_VALUE)
                .addContainerGap())
        );

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void AddBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_AddBtnMouseClicked
        if (SellerIDTB.getText().isEmpty()|| SellerNameTB.getText().isEmpty()||SellerPasswordTB.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Missing info");
        }
        else{
             try{
          
       Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin");
          PreparedStatement add = Con.prepareStatement("insert into SELLERTBL values (?,?,?,?)");
          add.setInt(1,Integer.valueOf(SellerIDTB.getText()));
          add.setString(2,SellerNameTB.getText());
          add.setString(3,SellerPasswordTB.getText());
          add.setString(4,SellerGenderCB.getSelectedItem().toString());
          int row = add.executeUpdate();
          JOptionPane.showMessageDialog(this, "seller added");
          Con.close();
          SelectSeller();
      }catch(SQLException e){
          e.printStackTrace();
      }
        }
       
    }//GEN-LAST:event_AddBtnMouseClicked

    private void SellerTblMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_SellerTblMouseClicked
        DefaultTableModel model = (DefaultTableModel) SellerTbl.getModel();
        int index = SellerTbl.getSelectedRow();
        SellerIDTB.setText(model.getValueAt(index, 0).toString());
        SellerNameTB.setText(model.getValueAt(index, 1).toString());
        SellerPasswordTB.setText(model.getValueAt(index, 2).toString());
        SellerGenderCB.setSelectedItem(model.getValueAt(index, 3).toString());
            
    }//GEN-LAST:event_SellerTblMouseClicked
       private void ExitLblMouseClicked(java.awt.event.MouseEvent evt) {                                     
       System.exit(0);
    } 
    private void ResetBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ResetBtnMouseClicked
       SellerIDTB.setText("");
       SellerPasswordTB.setText("");
       SellerNameTB.setText("");
       SellerGenderCB.setSelectedIndex(0);
    }//GEN-LAST:event_ResetBtnMouseClicked

    private void DeleteBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_DeleteBtnMouseClicked
        if (SellerIDTB.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Enter id");
        }
        else{
        try{
              Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin"); 
              String SellerID = SellerIDTB.getText();
              String Query = "Delete from SELLERTBL where SELLERID ="+SellerID;
              Statement Add = Con.createStatement();
              Add.executeUpdate(Query);
              Con.close();
              SelectSeller();
              JOptionPane.showMessageDialog(this, "Deleted");
        }catch(SQLException e){
            e.printStackTrace();
        }
        }
    }//GEN-LAST:event_DeleteBtnMouseClicked

    private void EditBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_EditBtnMouseClicked
         if (SellerIDTB.getText().isEmpty()|| SellerNameTB.getText().isEmpty()||SellerPasswordTB.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Missing info");
        }
        else{
             try{
          
          Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin");
          String Query = "Update SELLERTBL set SELLERNAME= '"+SellerNameTB.getText()+"'"+",SELLERPASSWORD='"+SellerPasswordTB.getText()+"'"+",SELLERGENDER='"+SellerGenderCB.getSelectedItem().toString()+"'"+"where SELLERID="+SellerIDTB.getText();
          Statement add = Con.createStatement();
          add.execute(Query);
          JOptionPane.showMessageDialog(this, "seller updated");
          Con.close();
          SelectSeller();
      }catch(SQLException e){
          e.printStackTrace();
      }
        }
       
    }//GEN-LAST:event_EditBtnMouseClicked

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Seller().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton AddBtn;
    private javax.swing.JButton DeleteBtn;
    private javax.swing.JButton EditBtn;
    private javax.swing.JLabel ExitLbl;
    private javax.swing.JButton ResetBtn;
    private javax.swing.JComboBox<String> SellerGenderCB;
    private javax.swing.JTextField SellerIDTB;
    private javax.swing.JTextField SellerNameTB;
    private javax.swing.JTextField SellerPasswordTB;
    private javax.swing.JTable SellerTbl;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JScrollPane jScrollPane1;
    // End of variables declaration//GEN-END:variables
}
