package clases;

import interfaces.Login;
import interfaces.lobby;
import javax.swing.JFrame;

public class Main {
    public static void main(String[] args) {
        lobby lobbyFrame = new lobby();

        lobbyFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        lobbyFrame.setVisible(true);
        /*Login lobbyFrame = new Login();

        lobbyFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        lobbyFrame.setVisible(true);*/
    }
}
