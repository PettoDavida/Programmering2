package sample;

import javafx.scene.Group;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.layout.StackPane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;

public class Controller {
    public static Node Sweden() {

        Rectangle bg = new Rectangle();
        bg.setWidth(300);
        bg.setHeight(200);
        bg.setFill(Color.MIDNIGHTBLUE);

        Rectangle yStripe = new Rectangle();
        yStripe.setWidth(300);
        yStripe.setHeight(40);
        yStripe.setTranslateY(0);
        yStripe.setFill(new Color(0xFF / 255.0f, 0xCD / 255.0f, 0.0f, 1.0f));

        Rectangle xStripe = new Rectangle();
        xStripe.setWidth(40);
        xStripe.setHeight(200);
        xStripe.setTranslateX(-40);
        xStripe.setFill(new Color(0xFF / 255.0f, 0xCD / 255.0f, 0.0f, 1.0f));

        StackPane root = new StackPane();
        root.getChildren().add(bg);
        root.getChildren().add(xStripe);
        root.getChildren().add(yStripe);

        return root;

    }

    public static Node Netherlands() {

        Rectangle vStripe = new Rectangle();

        vStripe.setWidth(600);
        vStripe.setHeight(100);
        vStripe.setTranslateX(0);
        vStripe.setFill(new Color(174 / 255.0f, 28 / 255.0f, 40 / 255.0f, 1.0f));

        Rectangle xStripe = new Rectangle();

        xStripe.setWidth(600);
        xStripe.setHeight(100);
        xStripe.setTranslateY(100);
        xStripe.setFill(Color.WHITE);

        Rectangle yStripe = new Rectangle();

        yStripe.setWidth(600);
        yStripe.setHeight(100);
        yStripe.setTranslateY(200);
        yStripe.setFill(new Color(33 / 255.0f, 70 / 255.0f, 139 / 255.0f, 1.0f));

        StackPane root = new StackPane();
        root.getChildren().add(vStripe);
        root.getChildren().add(xStripe);
        root.getChildren().add(yStripe);

        return root;
    }

    public static Node Switzerland() {

        Rectangle xStripe = new Rectangle();
        Rectangle yStripe = new Rectangle();


        xStripe.setWidth(75);
        xStripe.setHeight(200);
        xStripe.setFill(Color.WHITE);

        yStripe.setWidth(200);
        yStripe.setHeight(75);
        yStripe.setFill(Color.WHITE);

        Rectangle bg = new Rectangle();
        bg.setFill(new Color(213 / 255.0f, 43 / 255.0f, 30 / 255.0f, 1.0f));
        bg.setWidth(300);
        bg.setHeight(300);

        StackPane root = new StackPane();
        root.getChildren().add(bg);
        root.getChildren().add(xStripe);
        root.getChildren().add(yStripe);

        return root;

    }

    public static Node Ukraine() {

        Rectangle vStripe = new Rectangle();

        vStripe.setWidth(600);
        vStripe.setHeight(150);
        vStripe.setTranslateX(0);
        vStripe.setFill(new Color(0 / 255.0f, 91 / 255.0f, 187 / 255.0f, 1.0f));

        Rectangle yStripe = new Rectangle();

        yStripe.setWidth(600);
        yStripe.setHeight(150);
        yStripe.setTranslateY(150);
        yStripe.setFill(new Color(255 / 255.0f, 213 / 255.0f, 0 / 255.0f, 1.0f));


        StackPane root = new StackPane();
       root.getChildren().add(vStripe);
        root.getChildren().add(yStripe);

        return root;

    }


}