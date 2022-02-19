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
public class Selling extends javax.swing.JFrame {

    /**
     * Creates new form Selling
     */
    public Selling() {
        initComponents();
        SelectProduct();
        SelectCategory();
    }
    double UPrice,total,allTotal;
    int AvailQty,ProdID;
    String selectedCat="all";
    Connection Con = null;
    Statement statement = null;
    ResultSet resultSet = null;
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        ExitLbl = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        BillIDTB = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        NameTB = new javax.swing.JTextField();
        jLabel8 = new javax.swing.JLabel();
        QtyTB = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        CategoryCB = new javax.swing.JComboBox<>();
        jLabel4 = new javax.swing.JLabel();
        ResetBtn = new javax.swing.JButton();
        AddBtn = new javax.swing.JButton();
        PrintBtn = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        ProdTbl = new javax.swing.JTable();
        jScrollPane2 = new javax.swing.JScrollPane();
        BillTxt = new javax.swing.JTextArea();
        jLabel3 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setUndecorated(true);

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
        jLabel7.setText("BILLING");

        BillIDTB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        BillIDTB.setForeground(new java.awt.Color(255, 153, 0));

        jLabel6.setBackground(new java.awt.Color(255, 153, 0));
        jLabel6.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(255, 153, 0));
        jLabel6.setText("BillID");

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

        CategoryCB.setFont(new java.awt.Font("Calibri", 1, 14)); // NOI18N
        CategoryCB.setForeground(new java.awt.Color(255, 153, 0));
        CategoryCB.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "all" }));
        CategoryCB.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                CategoryCBİtemStateChanged(evt);
            }
        });

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

        PrintBtn.setBackground(new java.awt.Color(255, 153, 0));
        PrintBtn.setFont(new java.awt.Font("Calibri", 1, 18)); // NOI18N
        PrintBtn.setBorder(null);
        PrintBtn.setBorderPainted(false);
        PrintBtn.setLabel("Print");
        PrintBtn.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                PrintBtnMouseClicked(evt);
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

        BillTxt.setColumns(20);
        BillTxt.setRows(5);
        jScrollPane2.setViewportView(BillTxt);

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(15, 15, 15)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addComponent(jLabel8)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(NameTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addComponent(jLabel6)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(BillIDTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addComponent(jLabel9)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 54, Short.MAX_VALUE)
                                .addComponent(QtyTB, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(38, 38, 38)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 392, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                                .addComponent(AddBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(ResetBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(PrintBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 104, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(23, 23, 23)))))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel4)
                        .addGap(18, 18, 18)
                        .addComponent(CategoryCB, javax.swing.GroupLayout.PREFERRED_SIZE, 226, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(59, 59, 59))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 380, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap())))
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel7)
                .addGap(317, 317, 317)
                .addComponent(ExitLbl)
                .addContainerGap())
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jLabel7))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(ExitLbl)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 8, Short.MAX_VALUE)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(CategoryCB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel4))
                        .addGap(18, 18, 18)))
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BillIDTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel6))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel8)
                            .addComponent(NameTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(11, 11, 11)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(QtyTB, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel9))
                        .addGap(18, 18, 18)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(AddBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(ResetBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(PrintBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 182, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 354, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap())
        );

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
                .addGap(13, 13, 13)
                .addComponent(jLabel3, javax.swing.GroupLayout.DEFAULT_SIZE, 86, Short.MAX_VALUE)
                .addGap(15, 15, 15)
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel3))
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

    private void ExitLblMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ExitLblMouseClicked
        System.exit(0);
    }//GEN-LAST:event_ExitLblMouseClicked
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
            if(selectedCat.equals("all")){
               resultSet = statement.executeQuery("Select * from PRODUCTTBL");
            }
            else
            {
               resultSet = statement.executeQuery("Select * from PRODUCTTBL where PRODUCTCATEGORY='"+selectedCat+"'");
            }
            ProdTbl.setModel(DbUtils.resultSetToTableModel(resultSet));
            Con.close();
       }catch(Exception e){
           
       }
       
    }
    private void ResetBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ResetBtnMouseClicked
        BillIDTB.setText("");
        NameTB.setText("");
        QtyTB.setText("");
    }//GEN-LAST:event_ResetBtnMouseClicked
int i = 0;
    private void AddBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_AddBtnMouseClicked
        if (QtyTB.getText().isEmpty() || NameTB.getText().isEmpty()) {
             JOptionPane.showMessageDialog(this, "Missing info");
        }
        else if(AvailQty<=Integer.valueOf(QtyTB.getText())){
             JOptionPane.showMessageDialog(this, "Not Enough Stock");
        }
        else{
            total = UPrice * Integer.valueOf(QtyTB.getText());
          try{
            Con =  DriverManager.getConnection("jdbc:derby://localhost:1527/ShopMarketDB","admin","admin");
            AvailQty -=Integer.valueOf( QtyTB.getText());
            String Query = "Update PRODUCTTBL set PRODUCTQTY="+AvailQty+""+"where PRODUCTID="+ProdID;
            Statement add = Con.createStatement();
            add.execute(Query);
            Con.close();
            SelectProduct();
            }
           catch(SQLException e){
             e.printStackTrace();
           }
            allTotal+=total;
            i++;
            if (i==1) {
                BillTxt.setText(BillTxt.getText()+"==========SHOP========\n"+" NUM                PRODUCT    PRICE     QUANTITY     TOTAL \n "
                        +i+ "\t"+NameTB.getText()+"                  "+ UPrice +"          "+QtyTB.getText()+"                     "+total+"\n ");
            }
            else{
            BillTxt.setText(BillTxt.getText()+
               +i+ "\t"+NameTB.getText()+"                  "+ UPrice +"          "+QtyTB.getText()+"                     "+total+"\n");
            }
        }
    }//GEN-LAST:event_AddBtnMouseClicked

    private void PrintBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_PrintBtnMouseClicked
        try{
           BillTxt.setText("ALL = " + allTotal);
           BillTxt.print();
        }catch(Exception e){
           
        }
    }//GEN-LAST:event_PrintBtnMouseClicked
                            
  
    private void ProdTblMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ProdTblMouseClicked
        DefaultTableModel model = (DefaultTableModel) ProdTbl.getModel();
        int index = ProdTbl.getSelectedRow();
        ProdID=Integer.valueOf(model.getValueAt(index, 0).toString());
        AvailQty = Integer.valueOf(model.getValueAt(index, 2).toString());
        UPrice = Double.valueOf(model.getValueAt(index, 3).toString());
        NameTB.setText(model.getValueAt(index, 1).toString());
    }//GEN-LAST:event_ProdTblMouseClicked

    private void jLabel3MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jLabel3MouseClicked
        new Login().setVisible(true);
        this.dispose();
    }//GEN-LAST:event_jLabel3MouseClicked

    private void CategoryCBİtemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_CategoryCBİtemStateChanged
        selectedCat = CategoryCB.getSelectedItem().toString();
        SelectProduct();
    }//GEN-LAST:event_CategoryCBİtemStateChanged

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
            java.util.logging.Logger.getLogger(Selling.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Selling.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Selling.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Selling.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Selling().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton AddBtn;
    private javax.swing.JTextField BillIDTB;
    private javax.swing.JTextArea BillTxt;
    private javax.swing.JComboBox<String> CategoryCB;
    private javax.swing.JLabel ExitLbl;
    private javax.swing.JTextField NameTB;
    private javax.swing.JButton PrintBtn;
    private javax.swing.JTable ProdTbl;
    private javax.swing.JTextField QtyTB;
    private javax.swing.JButton ResetBtn;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    // End of variables declaration//GEN-END:variables
}
