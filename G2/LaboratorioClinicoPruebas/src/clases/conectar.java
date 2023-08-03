//ESTA CLASE SERVIRÁ PARA CONECTAR APROPIADAMENTE CON LA BASE DE DATOS
package clases;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.swing.JOptionPane;

public class conectar {
    
    private static Connection conn;
    private static final String DRIVER = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
    private static final String USER = "adminclinico";
    private static final String PASSWORD = "LaboratorioClinico+13";
    private static final String URL = "jdbc:sqlserver://servidorclinico.database.windows.net:1433;database=BaseClinica;encrypt=true;trustServerCertificate=false;hostNameInCertificate=*.database.windows.net;loginTimeout=30;";

    public conectar() {
        conn = null;
    }
    
    //Este método permitira retornar la conexión
    public Connection getConnection(){
        try {
            Class.forName(DRIVER);
            conn = DriverManager.getConnection(URL, USER, PASSWORD);
            if(conn != null){
                JOptionPane.showMessageDialog(null, "Conexión Establecida");
            }
        } catch (ClassNotFoundException | SQLException ex){
            JOptionPane.showMessageDialog(null, "Error al realizar conexión: " + ex);
        }
        return conn;
    }
    
    //Este método permite desconectar de la base de datos
    public void desconectar(){
        try{
          conn.close();
          JOptionPane.showMessageDialog(null, "Desconexión exitosa");
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, ex.getMessage(), "Error al desconectar", JOptionPane.ERROR_MESSAGE);
        }
        
    }
}