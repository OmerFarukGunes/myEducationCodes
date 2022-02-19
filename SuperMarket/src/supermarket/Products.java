/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package supermarket;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import net.proteanit.sql.DbUtils;

/**
 *
 * @author OmerFG
 */
public class Products extends javax.swing.JFrame {

    /**
     * Creates new form Products
     */
    public Products() {
        initComponents();
        SelectProduct(); 
        SelectCategory();
    }
    Connection Con = null;
    Statement statement = null;
    ResultSet resultSet = null;
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        ExitLbl = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        ProdIDTB = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        NameTB = new javax.swing.JTextField();
        jLabel8 = new javax.swing.JLabel();
        QtyTB = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        PriceTB = new javax.swing.JTextField();
        jLabel10 = new javax.swing.JLabel();
        CategoryCB = new javax.swing.JComboBox<>();
        jLabel4 = new javax.swing.JLabel();
        ResetBtn = new javax.swing.JButton();
        AddBtn = new javax.swing.JButton();
        EditBtn = new javax.swing.JButton();
        DeleteBtn = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        ProdTbl = new javax.swing.JTable();
        CategoriesNvg = new javax.swing.JLabel();
        SellerNvg = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setUndecorated(true);
        setPreferredSize(new java.awt.Dimension(969, 479));
        setResizable(false);

        jPanel1.setBackground(new java.awt.Color(255, 153, 0));
        jPanel1.setForeground(new java.awt.Color(255, 153, 0));

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));

        ExitLbl.setBackground(new java.awt.Color(255, 0, 0));
        ExitLbl.setFont(new java.awt.Font("Calibri", 1, 36)); // NOI18N
        ExitLbl.setForeground(new java.awt.Color(255, 0, 0));
        ExitLbl.setText("x");
        ExitLbl.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                ExitLblMouseClicked(evt);
            }
        });

        jLabel7.setBackground(new java.awt.Color(255, 153, 0));
        jLabel7.setFont(new java.awt.Font("Calibri", 1, 36)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(255, 153, 0));
        jLabel7.setText("MANAGE PRODUCTS");

        ProdIDTB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        ProdIDTB.setForeground(new java.awt.Color(255, 153, 0));

        jLabel5.setBackground(new java.awt.Color(255, 153, 0));
        jLabel5.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(255, 153, 0));
        jLabel5.setText("ProductID");

        NameTB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        NameTB.setForeground(new java.awt.Color(255, 153, 0));

        jLabel8.setBackground(new java.awt.Color(255, 153, 0));
        jLabel8.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(255, 153, 0));
        jLabel8.setText("Name");

        QtyTB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        QtyTB.setForeground(new java.awt.Color(255, 153, 0));

        jLabel9.setBackground(new java.awt.Color(255, 153, 0));
        jLabel9.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(255, 153, 0));
        jLabel9.setText("Quantity");

        PriceTB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        PriceTB.setForeground(new java.awt.Color(255, 153, 0));

        jLabel10.setBackground(new java.awt.Color(255, 153, 0));
        jLabel10.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(255, 153, 0));
        jLabel10.setText("Price");

        CategoryCB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        CategoryCB.setForeground(new java.awt.Color(255, 153, 0));
        CategoryCB.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "none" }));

        jLabel4.setBackground(new java.awt.Color(255, 153, 0));
        jLabel4.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(255, 153, 0));
        jLabel4.setText("Category");

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

        ProdTbl.setFont(new java.awt.Font("Calibri", 1, 12)); // NOI18N
        ProdTbl.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null},
                {null, null, null, null, null},
                {null, null, null, null, null},
                {null, null, null, null, null}
            },
            new String [] {
                "ID", "NAME", "QUANTITY", "PRICE", "CATEGORY"
            }
        ));
        ProdTbl.setRowHeight(18);
        ProdTbl.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                ProdTblMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(ProdTbl);

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGap(15, 15, 15)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel5)
                        .addGap(18, 18, 18)
                        .addComponent(ProdIDTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel9)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(QtyTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 14, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel8)
                    .addComponent(jLabel10))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(NameTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(PriceTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(45, 45, 45))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel7)
                        .addGap(231, 231, 231)
                        .addComponent(ExitLbl)
                        .addContainerGap())
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 663, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(78, 78, 78))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                                .addComponent(jLabel4)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(CategoryCB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(85, 85, 85))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                                .addComponent(AddBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(EditBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(26, 26, 26)
                                .addComponent(DeleteBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(26, 26, 26)
                                .addComponent(ResetBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(162, 162, 162))))
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
                        .addComponent(ProdIDTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(jLabel5)
                        .addComponent(jLabel8))
                    .addComponent(NameTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(8, 8, 8)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(QtyTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel9))
                        .addGap(9, 9, 9))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(PriceTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel10))))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(CategoryCB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(AddBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(DeleteBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(ResetBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(EditBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 223, Short.MAX_VALUE)
                .addContainerGap())
        );

        CategoriesNvg.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        CategoriesNvg.setForeground(new java.awt.Color(255, 255, 255));
        CategoriesNvg.setText("CATEGORIES");
        CategoriesNvg.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                CategoriesNvgMouseClicked(evt);
            }
        });

        SellerNvg.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        SellerNvg.setForeground(new java.awt.Color(255, 255, 255));
        SellerNvg.setText("SELLER");
        SellerNvg.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                SellerNvgMouseClicked(evt);
            }
        });

        jLabel3.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 255, 255));
        jLabel3.setText("LOGOUT");
        jLabel3.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jLabel3MouseClicked(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(CategoriesNvg, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(SellerNvg, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addComponent(jLabel3, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addGap(18, 18, 18)
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addGap(66, 66, 66)
                        .addComponent(SellerNvg)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CategoriesNvg)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jLabel3))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
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
    public void SelectCategory(){
     try{
            Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin");
            statement = Con.createStatement();
            resultSet = statement.executeQuery("Select * from CATEGORYTBL");
               while (resultSet.next()) {
                CategoryCB.addItem( resultSet.getString(2));
                }
            Con.close();
       }catch(Exception e){
           
       }
    }
    public void SelectProduct()
    {
       try{
            Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin");
            statement = Con.createStatement();
            resultSet = statement.executeQuery("Select * from PRODUCTTBL");
            ProdTbl.setModel(DbUtils.resultSetToTableModel(resultSet));
            Con.close();
       }catch(Exception e){
           
       }
       
    }
    private void AddBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_AddBtnMouseClicked
         if (ProdIDTB.getText().isEmpty()|| NameTB.getText().isEmpty()||PriceTB.getText().isEmpty()||QtyTB.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Missing info");
        }
        else{
             try{
          
       Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin");
          PreparedStatement add = Con.prepareStatement("insert into PRODUCTTBL values (?,?,?,?,?)");
          add.setInt(1,Integer.valueOf(ProdIDTB.getText()));
          add.setString(2,NameTB.getText());
          add.setInt(3,Integer.valueOf(QtyTB.getText()));
          add.setLong(4,Long.valueOf(PriceTB.getText()));
          add.setString(5,CategoryCB.getSelectedItem().toString());
          int row = add.executeUpdate();
          JOptionPane.showMessageDialog(this, "product added");
          Con.close();
          SelectProduct();
      }catch(SQLException e){
          e.printStackTrace();
      }
        }
       
    }//GEN-LAST:event_AddBtnMouseClicked

    private void EditBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_EditBtnMouseClicked
       if (ProdIDTB.getText().isEmpty()|| NameTB.getText().isEmpty()||PriceTB.getText().isEmpty()||QtyTB.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Missing info");
        }
        else{
             try{
          
          Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin");
          String Query = "Update PRODUCTTBL set PRODUCTNAME= '"+NameTB.getText()+"'"+",PRODUCTQTY='"+QtyTB.getText()+"'"+",PRODUCTCATEGORY='"+CategoryCB.getSelectedItem().toString()+"'"+",PRODUCTPRIVE='"+PriceTB.getText().toString()+"'"+"where PRODUCTID="+ProdIDTB.getText();
          Statement add = Con.createStatement();
          add.execute(Query);
          JOptionPane.showMessageDialog(this, "product updated");
          Con.close();
          SelectProduct();
      }catch(SQLException e){
          e.printStackTrace();
      }
        }
       
    }//GEN-LAST:event_EditBtnMouseClicked

    private void ResetBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ResetBtnMouseClicked
       ProdIDTB.setText("");
       NameTB.setText("");
       PriceTB.setText("");
       QtyTB.setText("");
       CategoryCB.setSelectedIndex(0);
    }//GEN-LAST:event_ResetBtnMouseClicked

    private void DeleteBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_DeleteBtnMouseClicked
        if (ProdIDTB.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Enter id");
        }
        else{
        try{
              Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin"); 
              String ProdID = ProdIDTB.getText();
              String Query = "Delete from PRODUCTTBL where PRODUCTID ="+ProdIDTB;
              Statement Add = Con.createStatement();
              Add.executeUpdate(Query);
              Con.close();
              SelectProduct();
              JOptionPane.showMessageDialog(this, "Deleted");
        }catch(SQLException e){
            e.printStackTrace();
        }
        }
    }//GEN-LAST:event_DeleteBtnMouseClicked

    private void ProdTblMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ProdTblMouseClicked
        DefaultTableModel model = (DefaultTableModel) ProdTbl.getModel();
        int index = ProdTbl.getSelectedRow();
        ProdIDTB.setText(model.getValueAt(index, 0).toString());
        NameTB.setText(model.getValueAt(index, 1).toString());
        QtyTB.setText(model.getValueAt(index, 2).toString());
        PriceTB.setText(model.getValueAt(index, 2).toString());
        CategoryCB.setSelectedItem(model.getValueAt(index, 3).toString());
    }//GEN-LAST:event_ProdTblMouseClicked

    private void ExitLblMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ExitLblMouseClicked
       System.exit(0);
    }//GEN-LAST:event_ExitLblMouseClicked

    private void SellerNvgMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_SellerNvgMouseClicked
        new Seller().setVisible(true);
        this.dispose();
    }//GEN-LAST:event_SellerNvgMouseClicked

    private void CategoriesNvgMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_CategoriesNvgMouseClicked
        new Category().setVisible(true);
        this.dispose();
    }//GEN-LAST:event_CategoriesNvgMouseClicked

    private void jLabel3MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jLabel3MouseClicked
       new Login().setVisible(true);
        this.dispose();
    }//GEN-LAST:event_jLabel3MouseClicked

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Products.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Products.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Products.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Products.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Products().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton AddBtn;
    private javax.swing.JLabel CategoriesNvg;
    private javax.swing.JComboBox<String> CategoryCB;
    private javax.swing.JButton DeleteBtn;
    private javax.swing.JButton EditBtn;
    private javax.swing.JLabel ExitLbl;
    private javax.swing.JTextField NameTB;
    private javax.swing.JTextField PriceTB;
    private javax.swing.JTextField ProdIDTB;
    private javax.swing.JTable ProdTbl;
    private javax.swing.JTextField QtyTB;
    private javax.swing.JButton ResetBtn;
    private javax.swing.JLabel SellerNvg;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel3;
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
