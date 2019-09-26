package sample;

import javafx.application.Application;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.control.RadioButton;
import javafx.scene.control.ToggleGroup;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.StackPane;
import javafx.scene.layout.VBox;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Main extends Application {
    public static void main(String[] args) {
        launch();
    }

    @Override
    public void start(Stage primaryStage) throws Exception {

        HashMap<String, Node> flaggor = new HashMap();
        flaggor.put("Sweden", Controller.Sweden());
        flaggor.put("Netherlands", Controller.Netherlands());
        flaggor.put("Switzerland", Controller.Switzerland());
        flaggor.put("Ukraine", Controller.Ukraine());

        StackPane stack = new StackPane();
        BorderPane root = new BorderPane();
        Rectangle bar = new Rectangle();

        bar.setWidth(150);
        bar.setHeight(500);
        bar.setFill(new Color(166 / 255f, 36 / 255f, 75 / 255f, 1));
        stack.getChildren().add(bar);

        VBox buttons = new VBox();
        ToggleGroup radio = new ToggleGroup();

        radio.selectedToggleProperty().addListener((observable, oldValue, newValue) -> {
            if (radio.selectedToggleProperty() != null) {
                String flagName = (String) radio.getSelectedToggle().getUserData();
                Node node = flaggor.get(flagName);
                root.setCenter(node);
            }
        });

        List keys = new ArrayList(flaggor.keySet());

        for (int i = 0; i < keys.size(); i++) {
            String name = (String) keys.get(i);
            RadioButton button = new RadioButton(name);
            button.setToggleGroup(radio);
            button.setUserData(name);
            buttons.getChildren().add(button);
        }

        stack.getChildren().add(buttons);
        root.setLeft(stack);
        Scene scene = new Scene(root, 500, 500, Color.LAVENDER);
        primaryStage.setScene(scene);
        primaryStage.show();
    }
}

