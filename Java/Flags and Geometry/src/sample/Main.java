package sample;
        import javafx.application.Application;
        import javafx.beans.value.ChangeListener;
        import javafx.beans.value.ObservableValue;
        import javafx.event.ActionEvent;
        import javafx.event.EventHandler;
        import javafx.scene.Group;
        import javafx.scene.Scene;
        import javafx.scene.control.Button;
        import javafx.scene.control.RadioButton;
        import javafx.scene.control.Toggle;
        import javafx.scene.control.ToggleGroup;
        import javafx.scene.layout.BorderPane;
        import javafx.scene.layout.StackPane;
        import javafx.scene.layout.VBox;
        import javafx.scene.paint.Color;
        import javafx.scene.shape.Rectangle;
        import javafx.stage.Stage;

public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception {

        StackPane stack = new StackPane();
        BorderPane root = new BorderPane();
        Rectangle bar = new Rectangle();
        bar.setWidth(150);
        bar.setHeight(500);
        bar.setFill(new Color(166/255f,36/255f,75/255f,1));
        stack.getChildren().add(bar);
        VBox buttons = new VBox();
        ToggleGroup radio = new ToggleGroup();
        radio.selectedToggleProperty().addListener((observable, oldValue, newValue) -> {
            if (radio.selectedToggleProperty() != null ){
                int flagindex = (int)radio.getSelectedToggle().getUserData();

                if (flagindex == 0){
                    root.getChildren().add(Controller.Sweden());
                }
            }
        });
        RadioButton sweden = new RadioButton("Sweden");
        RadioButton netherlands = new RadioButton("Netherlands");
        sweden.setToggleGroup(radio);
        sweden.setUserData(0);
        netherlands.setToggleGroup(radio);
        netherlands.setUserData(1);
        stack.getChildren().add(buttons);
        buttons.getChildren().add(sweden);
        buttons.getChildren().add(netherlands);
        root.setLeft(stack);
        Scene scene = new Scene(root, 500, 500, Color.LAVENDER);
        primaryStage.setScene(scene);
        primaryStage.show();




    }

    public static void main(String[] args) {
        launch();
    }

}

