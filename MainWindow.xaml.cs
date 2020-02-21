/* Dominic Langowski
    2/19/2020
    Computer Science PC program*/
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

namespace Computer_Science_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double total;
        double totaltax;
        double cpu;                //PARTS
        double cpucooler;
        double motherboard;
        double RAM;
        double graphics_card;
        double hard_drive;
        double power_supply;
        double computer_case;
        double windows_10_64bit;
        double pixel_battery;       // PARTS

        double shippingcost_1;
        double shippingcost_2;
        double shippingcost_3;
        double shippingcosts_4;

        double tax;

        public MainWindow()         
        {
            InitializeComponent();
            total = 0.0;
            totaltax = 0.0;

            cpu = 109.99;
            cpucooler = 23.99;
            motherboard = 109.99;
            RAM = 95.99;
            graphics_card = 199.99;
            hard_drive = 89.99;
            power_supply = 89.99;
            computer_case = 44.99;
            windows_10_64bit = 119.00;
            pixel_battery = 22.99;

            shippingcost_1 = 4.99;
            shippingcost_2 = 7.99;
            shippingcost_3 = 5.99;
            shippingcosts_4 = 9.99;

            tax = 0.13;

            
        }

       
        
        // Computer parts button
        private void BtnComputer_Parts_Click(object sender, RoutedEventArgs e)
        {
            chkCPU.Visibility = Visibility.Visible;
            chkMotherBoard.Visibility = Visibility.Visible;
            chkRam.Visibility = Visibility.Visible;
            chkCpuCooler.Visibility = Visibility.Visible;
            chkGraphicsCard.Visibility = Visibility.Visible;
            chkHardDrive.Visibility = Visibility.Visible;
            chkPowerSupply.Visibility = Visibility.Visible;
            chkComputerCase.Visibility = Visibility.Visible;

            lblOperatingSystems.Visibility = Visibility.Visible;
            chkWindows10.Visibility = Visibility.Visible;
            chkLinux.Visibility = Visibility.Visible;

            lblGooglePixelBattery.Visibility = Visibility.Visible;
            chkGooglePixelBattery.Visibility = Visibility.Visible;


        }
        // Computer parts button

        //Total Cost Button
        private void BtnTOtal_Click(object sender, RoutedEventArgs e)
        {
            lblTotalPrice.Content = total.ToString("$#.00");
            lblTotalTax.Content = totaltax.ToString("$#.00");

            lblTotalPrice.Visibility = Visibility.Visible;
            lblBeforeTax.Visibility = Visibility.Visible;
            lblAfterTax.Visibility = Visibility.Visible;
            lblTotalTax.Visibility = Visibility.Visible;
        }
        //Total Cost Button

        // For the CPU
        private void ChkCPU_Checked(object sender, RoutedEventArgs e)
        {
            lblCPU.Visibility = Visibility.Visible;
            lblURLCPU.Visibility = Visibility.Visible;
            imgCPU.Visibility = Visibility.Visible;
            txtCPUshipping.Visibility = Visibility.Visible;
            txtCPUPrice.Visibility = Visibility.Visible;
            total += cpu + shippingcost_1;
            totaltax += (cpu + shippingcost_1) + ((cpu + shippingcost_1) * tax);
        }

        private void ChkCPU_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCPU.Visibility = Visibility.Collapsed;
            lblURLCPU.Visibility = Visibility.Collapsed;
            imgCPU.Visibility = Visibility.Collapsed;
            txtCPUshipping.Visibility = Visibility.Collapsed;
            txtCPUPrice.Visibility = Visibility.Collapsed;
            total -= cpu + shippingcost_1;
            totaltax -= (cpu + shippingcost_1) + ((cpu + shippingcost_1) * tax);

        }
        // For the CPU

        // For the CPU Cooler
        private void ChkCpuCooler_Checked(object sender, RoutedEventArgs e)
        {
            lblCpuCooler.Visibility = Visibility.Visible;
            lblCpuCoolerURL.Visibility = Visibility.Visible;
            imgCpuCooler.Visibility = Visibility.Visible;
            txtCpuCoolerPrice.Visibility = Visibility.Visible;
            txtCPUCoolershipping.Visibility = Visibility.Visible;
            total += cpucooler + shippingcost_2;
            totaltax += (cpucooler + shippingcost_2) + ((cpu + shippingcost_2) * tax);
        }

        private void ChkCpuCooler_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCpuCooler.Visibility = Visibility.Collapsed;
            lblCpuCoolerURL.Visibility = Visibility.Collapsed;
            imgCpuCooler.Visibility = Visibility.Collapsed;
            txtCpuCoolerPrice.Visibility = Visibility.Collapsed;
            txtCPUCoolershipping.Visibility = Visibility.Collapsed;
            total -= cpucooler + shippingcost_2;
            totaltax -= (cpucooler + shippingcost_2) + ((cpucooler + shippingcost_2) * tax);
        }
        // For the CPU Cooler
       
        // For the MotherBoard
        private void ChkMotherBoard_Checked(object sender, RoutedEventArgs e)
        {
            lblMotherBoard.Visibility = Visibility.Visible;
            lblURLMotherBoard.Visibility = Visibility.Visible;
            imgMotherBoard.Visibility = Visibility.Visible;
            txtMotherBoardPrice.Visibility = Visibility.Visible;
            txtMotherBoardshipping.Visibility = Visibility.Visible;
            total += motherboard + shippingcost_3;
            totaltax += (motherboard + shippingcost_3) + ((motherboard + shippingcost_3) * tax);
        }

        private void ChkMotherBoard_Unchecked(object sender, RoutedEventArgs e)
        {
            lblMotherBoard.Visibility = Visibility.Collapsed;
            lblURLMotherBoard.Visibility = Visibility.Collapsed;
            imgMotherBoard.Visibility = Visibility.Collapsed;
            txtMotherBoardPrice.Visibility = Visibility.Collapsed;
            txtMotherBoardshipping.Visibility = Visibility.Collapsed;
            total -= motherboard + shippingcost_3;
            totaltax -= (motherboard + shippingcost_3) + ((motherboard + shippingcost_3) * tax);
        }
        // For the MotherBoard
        
        // For the Ram
        private void ChkRam_Checked(object sender, RoutedEventArgs e)
        {
            lblRam.Visibility = Visibility.Visible;
            lblURLRam.Visibility = Visibility.Visible;
            imgRam.Visibility = Visibility.Visible;
            txtRamPrice.Visibility = Visibility.Visible;
            txtRAMshipping.Visibility = Visibility.Visible;
            total += RAM + shippingcost_2;
            totaltax += (RAM + shippingcost_2) + ((RAM + shippingcost_2) * tax);
        }

        private void ChkRam_Unchecked(object sender, RoutedEventArgs e)
        {
            lblRam.Visibility = Visibility.Collapsed;
            lblURLRam.Visibility = Visibility.Collapsed;
            imgRam.Visibility = Visibility.Collapsed;
            txtRamPrice.Visibility = Visibility.Collapsed;
            txtRAMshipping.Visibility = Visibility.Collapsed;
            total -= RAM + shippingcost_2;
            totaltax -= (RAM + shippingcost_2) + ((RAM + shippingcost_2) * tax);
        }
        // For the Ram
       
        //For the Graphics Card
        private void ChkGraphicsCard_Checked(object sender, RoutedEventArgs e)
        {
            lblGraphicsCard.Visibility = Visibility.Visible;
            lblURLGraphicsCard.Visibility = Visibility.Visible;
            imgGraphicsCard.Visibility = Visibility.Visible;
            txtGraphicsCardPrice.Visibility = Visibility.Visible;
            txtGraphicshipping.Visibility = Visibility.Visible;
            total += graphics_card + shippingcost_2;
            totaltax += (graphics_card + shippingcost_2) + ((graphics_card + shippingcost_2) * tax);
        }

        private void ChkGraphicsCard_Unchecked(object sender, RoutedEventArgs e)
        {
            lblGraphicsCard.Visibility = Visibility.Collapsed;
            lblURLGraphicsCard.Visibility = Visibility.Collapsed;
            imgGraphicsCard.Visibility = Visibility.Collapsed;
            txtGraphicsCardPrice.Visibility = Visibility.Collapsed;
            txtGraphicshipping.Visibility = Visibility.Collapsed;
            total -= graphics_card + shippingcost_2;
            totaltax -= (graphics_card + shippingcost_2) + ((graphics_card + shippingcost_2) * tax);
        }
        // For the Graphics Card
        
         // For the Hard Drive
        private void ChkHardDrive_Checked(object sender, RoutedEventArgs e)
        {
            lblHardDrive.Visibility = Visibility.Visible;
            lblURLHardDrive.Visibility = Visibility.Visible;
            imgHardDrive.Visibility = Visibility.Visible;
            txtHardDrivePrice.Visibility = Visibility.Visible;
            txtHardDriveshipping.Visibility = Visibility.Visible;
            total += hard_drive + shippingcost_3;
            totaltax += (hard_drive + shippingcost_3) + ((hard_drive + shippingcost_3) * tax);
        }

        private void ChkHardDrive_Unchecked(object sender, RoutedEventArgs e)
        {
            lblHardDrive.Visibility = Visibility.Collapsed;
            lblURLHardDrive.Visibility = Visibility.Collapsed;
            imgHardDrive.Visibility = Visibility.Collapsed;
            txtHardDrivePrice.Visibility = Visibility.Collapsed;
            txtHardDriveshipping.Visibility = Visibility.Collapsed;
            total -= hard_drive + shippingcost_3;
            totaltax -= (hard_drive + shippingcost_3) + ((hard_drive + shippingcost_3) * tax);
        }
        // For the Hard Drive

        // For the Power Supply
        private void ChkHardDrive_Checked_1(object sender, RoutedEventArgs e)
        {
            lblPowerSupply.Visibility = Visibility.Visible;
            lblURLPowerSupply.Visibility = Visibility.Visible;
            imgPowerSupply.Visibility = Visibility.Visible;
            txtPowerSupplyPrice.Visibility = Visibility.Visible;
            txtPowerSupplyshipping.Visibility = Visibility.Visible;
            total += power_supply + shippingcost_3;
            totaltax += (power_supply + shippingcost_3) + ((power_supply + shippingcost_3) * tax);
        }

        private void ChkHardDrive_Unchecked_1(object sender, RoutedEventArgs e)
        {
            lblPowerSupply.Visibility = Visibility.Collapsed;
            lblURLPowerSupply.Visibility = Visibility.Collapsed;
            imgPowerSupply.Visibility = Visibility.Collapsed;
            txtPowerSupplyPrice.Visibility = Visibility.Collapsed;
            txtPowerSupplyshipping.Visibility = Visibility.Collapsed;
            total -= power_supply + shippingcost_3;
            totaltax -= (power_supply + shippingcost_3) + ((power_supply + shippingcost_3) * tax);
        }
        // For the Power Supply
    
        // For the Computer Case
        private void ChkComputerCase_Checked(object sender, RoutedEventArgs e)
        {
            lblComputerCase.Visibility = Visibility.Visible;
            lblURLComputerCase.Visibility = Visibility.Visible;
            imgComputerCase.Visibility = Visibility.Visible;
            txtComputerCasePrice.Visibility = Visibility.Visible;
            txtComputerCaseshipping.Visibility = Visibility.Visible;
            total += computer_case + shippingcosts_4;
            totaltax += (computer_case + shippingcosts_4) + ((computer_case + shippingcosts_4) * tax);
        }

        private void ChkComputerCase_Unchecked(object sender, RoutedEventArgs e)
        {
            lblComputerCase.Visibility = Visibility.Collapsed;
            lblURLComputerCase.Visibility = Visibility.Collapsed;
            imgComputerCase.Visibility = Visibility.Collapsed;
            txtComputerCasePrice.Visibility = Visibility.Collapsed;
            txtComputerCaseshipping.Visibility = Visibility.Collapsed;
            total -= computer_case + shippingcosts_4;
            totaltax -= (computer_case + shippingcosts_4) + ((computer_case + shippingcosts_4) * tax);
        }
        // For the Computer Case

        // Windows 10
        private void ChkWindows10_Checked(object sender, RoutedEventArgs e)
        {
            lblURLWindows10.Visibility = Visibility.Visible;
            txtWindoes10Price.Visibility = Visibility.Visible;
            total += windows_10_64bit;
        }

        private void ChkWindows10_Unchecked(object sender, RoutedEventArgs e)
        {
            lblURLWindows10.Visibility = Visibility.Collapsed;
            txtWindoes10Price.Visibility = Visibility.Collapsed;
            total -= windows_10_64bit;

        }
        // Windows 10

        // Linux
        private void ChkLinux_Checked(object sender, RoutedEventArgs e)
        {
            lblURLLinux.Visibility = Visibility.Visible;
            lblWindowsEmulator.Visibility = Visibility.Visible;
            lblURLWindowsEmulator.Visibility = Visibility.Visible;
            txtPrice.Visibility = Visibility.Visible;
        }

        private void ChkLinux_Unchecked(object sender, RoutedEventArgs e)
        {
            lblURLLinux.Visibility = Visibility.Collapsed;
            lblWindowsEmulator.Visibility = Visibility.Collapsed;
            lblURLWindowsEmulator.Visibility = Visibility.Collapsed;
            txtPrice.Visibility = Visibility.Collapsed;
        }
        // Linux

            // Pixel Battery
        private void ChkGooglePixelBattery_Checked(object sender, RoutedEventArgs e)
        {
            
            
            lblURLGooglePixelBattery.Visibility = Visibility.Visible;
            txtPixelBatteryPrice.Visibility = Visibility.Visible;
            total += pixel_battery;

        }

        private void ChkGooglePixelBattery_Unchecked(object sender, RoutedEventArgs e)
        {
           
            lblURLGooglePixelBattery.Visibility = Visibility.Collapsed;
            txtPixelBatteryPrice.Visibility = Visibility.Collapsed;
            total -= pixel_battery;
        }
        // Pixel Battery

       
      
    }

}
