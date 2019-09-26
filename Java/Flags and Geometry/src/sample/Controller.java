package sample;

import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Rectangle;
import javafx.scene.transform.Rotate;

public class Controller {
    public static FlagClass Sweden() {
        FlagClass flagga = new FlagClass();
        Rectangle bg = new Rectangle();
        bg.setWidth(300);
        bg.setHeight(200);
        bg.setFill(Color.BLUE);

        Rectangle hStripe = new Rectangle();
        hStripe.setWidth(300);
        hStripe.setHeight(40);
        hStripe.setTranslateY(80);
        hStripe.setFill(Color.YELLOW);

        Rectangle vStripe = new Rectangle();
        vStripe.setWidth(40);
        vStripe.setHeight(200);
        vStripe.setTranslateX(80);
        vStripe.setFill(Color.YELLOW);

        flagga.getChildren().addAll(bg, vStripe, hStripe);

        return flagga;

    }

    public static FlagClass Netherlands() {
        FlagClass flagga = new FlagClass();

        Rectangle vStripe = new Rectangle();

        vStripe.setWidth(600);
        vStripe.setHeight(100);
        vStripe.setTranslateX(0);
        vStripe.setFill(Color.DARKRED);

        Rectangle vStripe2 = new Rectangle();

        vStripe2.setWidth(600);
        vStripe2.setHeight(100);
        vStripe2.setTranslateY(100);
        vStripe2.setFill(Color.WHITE);

        Rectangle vStripe3 = new Rectangle();

        vStripe3.setWidth(600);
        vStripe3.setHeight(100);
        vStripe3.setTranslateY(200);
        vStripe3.setFill(Color.BLUE);

        Group root = new Group(vStripe, vStripe2, vStripe3);

        Scene scene = new Scene(root, 600, 300, Color.LAVENDER);

        flagga.getChildren().addAll(vStripe, vStripe2, vStripe3);

        return flagga;
    }

    public static FlagClass Switzerland() {
        FlagClass flagga = new FlagClass();

        Rectangle vStripe = new Rectangle();

        vStripe.setWidth(600);
        vStripe.setHeight(300);
        vStripe.setTranslateX(0);
        vStripe.setFill(Color.RED);

        Group root = new Group(vStripe);

        Scene scene = new Scene(root, 600, 300, Color.LAVENDER);

        flagga.getChildren().addAll(vStripe);

        return flagga;

    }

    public static FlagClass Ukraine() {
        FlagClass flagga = new FlagClass();

        Rectangle vStripe = new Rectangle();

        vStripe.setWidth(600);
        vStripe.setHeight(150);
        vStripe.setTranslateX(0);
        vStripe.setFill(Color.BLUE);

        Rectangle vStripe2 = new Rectangle();

        vStripe2.setWidth(600);
        vStripe2.setHeight(150);
        vStripe2.setTranslateY(150);
        vStripe2.setFill(Color.YELLOW);

        // Group root = new Group(vStripe, vStripe2);

        flagga.getChildren().addAll(vStripe, vStripe2);

        return flagga;

    }


}