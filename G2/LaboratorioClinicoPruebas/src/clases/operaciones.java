package clases;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.JOptionPane;

public class operaciones {

    //Metodología CRUD para la tabla TB_EXPEDIENTE
    private final String SQL_INSERT = "INSERT INTO TB_EXPEDIENTE (nombre_ex, genero_ex, telefono_ex, nit_ex, direccion_ex, quien_refiere, tipo_muestra, codigo_auxiliar, fecha_nacimiento) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?);";
    private String SQL_SELECT = "SELECT * FROM TB_EXPEDIENTE WHERE id_expediente = ?";;
    private final String SQL_UPDATE = "UPDATE TB_EXPEDIENTE SET nombre_ex = ?, genero_ex = ?, telefono_ex = ?, nit_ex = ?, direccion_ex = ?, quien_refiere = ?, tipo_muestra = ?, codigo_auxiliar = ?, fecha_nacimiento = ? WHERE id_expediente = ?;";
    private final String SQL_DELETE = "DELETE FROM TB_EXPEDIENTE WHERE id_expediente = ?;";

    //Metodología de Busqueda para la tabla TB_LABORATORIO
    private final String SQL_SELECT_LABORATORIO = "SELECT * FROM TB_LABORATORIO WHERE codigo_lab = ?;";
    
    private PreparedStatement PS;
    private conectar CN;

    public operaciones() {
        PS = null;
        CN = new conectar();
    }

    public int insertDatos(String nombre_ex, String genero_ex, String telefono_ex, String nit_ex, String direccion_ex, String quien_refiere, String tipo_muestra, String codigo_auxiliar, String fecha_nacimiento) {
        try {
            PS = CN.getConnection().prepareStatement(SQL_INSERT);
            PS.setString(1, nombre_ex);
            PS.setString(2, genero_ex);
            PS.setString(3, telefono_ex);
            PS.setString(4, nit_ex);
            PS.setString(5, direccion_ex);
            PS.setString(6, quien_refiere);
            PS.setString(7, tipo_muestra);
            PS.setString(8, codigo_auxiliar);
            PS.setString(9, fecha_nacimiento);
            int res = PS.executeUpdate();
            if (res > 0) {
                JOptionPane.showMessageDialog(null, "Registro Guardado");
            }
            return res;
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error al guardar los datos en DB: " + e);
            return -1;
        } finally {
            PS = null;
            CN.desconectar();
        }
    }

    public ResultSet selectDatos(int numeroExpediente) {
    try {
        PreparedStatement PS = CN.getConnection().prepareStatement(SQL_SELECT);
        PS.setInt(1, numeroExpediente);
        ResultSet rs = PS.executeQuery();
        return rs;
    } catch (SQLException e) {
        // Manejar la excepción, por ejemplo, imprimir en la consola
        e.printStackTrace();
        return null;
    }
}

    public int updateDatos(String nombre_ex, String genero_ex, String telefono_ex, String nit_ex, String direccion_ex, String quien_refiere, String tipo_muestra, String codigo_auxiliar, String fecha_nacimiento, int id_expediente) {
        try {
            PS = CN.getConnection().prepareStatement(SQL_UPDATE);
            PS.setString(1, nombre_ex);
            PS.setString(2, genero_ex);
            PS.setString(3, telefono_ex);
            PS.setString(4, nit_ex);
            PS.setString(5, direccion_ex);
            PS.setString(6, quien_refiere);
            PS.setString(7, tipo_muestra);
            PS.setString(8, codigo_auxiliar);
            PS.setString(9, fecha_nacimiento);
            PS.setInt(10, id_expediente);
            int res = PS.executeUpdate();
            if (res > 0) {
                JOptionPane.showMessageDialog(null, "Registro Actualizado");
            }
            return res;
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error al actualizar los datos en DB: " + e);
            return -1;
        } finally {
            PS = null;
            CN.desconectar();
        }
    }

    public int deleteDatos(int id_expediente) {
        try {
            PS = CN.getConnection().prepareStatement(SQL_DELETE);
            PS.setInt(1, id_expediente);
            int res = PS.executeUpdate();
            if (res > 0) {
                JOptionPane.showMessageDialog(null, "Registro Eliminado");
            }
            return res;
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error al eliminar los datos en DB: " + e);
            return -1;
        } finally {
            PS = null;
            CN.desconectar();
        }
    }
    
    public ResultSet buscarLaboratorioPorCodigo(int codigo_lab) {
        try {
            PreparedStatement PS = CN.getConnection().prepareStatement(SQL_SELECT_LABORATORIO);
            PS.setInt(1, codigo_lab);
            ResultSet rs = PS.executeQuery();
            return rs;
        } catch (SQLException e) {
            return null;
        }
    }
}

