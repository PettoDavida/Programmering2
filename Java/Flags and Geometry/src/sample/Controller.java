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



}