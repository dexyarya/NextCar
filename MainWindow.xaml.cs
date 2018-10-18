using NextCar.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NextCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car nextCar;

        public MainWindow()
        {
            InitializeComponent();

            AccubaterryController accubaterryController = new AccubaterryController();
            DoorController doorController = new DoorController();
            EngineController engineController = new EngineController();

            nextCar = new Car();
            nextCar.setAccubaterryController(accubaterryController);
            nextCar.setDoorController(doorController);
            nextCar.setEngineController(engineController);
        }


        private void OnAccuButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean powerIsOn = nextCar.powerIsReady();
            if (powerIsOn)
            {
                this.nextCar.turnOffPower();
                this.AccuState.Content = "no power";
                this.AccuButton.Content = "OFF";
            }
            else
            {
                this.nextCar.turnOnPower();
                this.AccuState.Content = "power is ready";
                this.AccuButton.Content = "ON";
            }
        }

        private void OnDoorButtonClicked(object sender, RoutedEventArgs e)
        {
            nextCar.closeTheDoor();

            Boolean doorIsLocked = nextCar.doorIsLocked();
            Boolean doorIsClosed = nextCar.doorIsClosed();
            if (doorIsClosed && !doorIsLocked)
            {
                this.nextCar.lockTheDoor();
                this.DoorState.Content = "door is locked";
                this.DoorButton.Content = "ON";
            }
            else if(doorIsLocked && !doorIsLocked)
            {
                this.nextCar.unlockTheDoor();
                this.DoorState.Content = "door is unlocked";
                this.DoorButton.Content = "OFF";
            }

        }

        private void OnStartButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean engineIsOn = nextCar.engineIsReady();
            Boolean doorIsLocked = nextCar.doorIsLocked();
            Boolean doorIsClosed = nextCar.doorIsClosed();
            Boolean powerIsOn = nextCar.powerIsReady();
            
             if(!powerIsOn){
                MessageBox.Show("Ups! Turn on the accu power, please");
             }
             if(!doorIsClosed){
                MessageBox.Show("Ups! Close the door, please");
             }
             if(!engineIsOn){
                MessageBox.Show("Ups! Turn on the engine, please");
             }
             if(powerIsOn && doorIsClosed && engineIsOn){
                MessageBox.Show("Broom! car is ready");
             }
             

        }


        //
        private void EngineButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean engineIsOn = nextCar.engineIsReady();
            if (engineIsOn)
            {
                this.nextCar.turnOfengine();
                this.EngineState.Content = "Engine Is Off";
                this.EngineButton.Content = "OFF";
            }
            else
            {
                this.nextCar.turnOnengine();
                this.EngineState.Content = "Engine is ready";
                this.EngineButton.Content = "ON";
            }

        }

    
    }
}
