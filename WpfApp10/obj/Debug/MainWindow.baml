   M S B A M L   `   `   `  ????C  ?WpfApp10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp10WpfApp10  5   	       WpfApp10.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp10     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6,   $	??550??6;   $	??850??6K   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $	??45* ?6   ?? 5      $	??31* ?6    ? RowDefinitions 5   
   ?? 5      $??80 ?6   6*   ?? 5      $??* ?6   6)   .+?5   
   ??    	StackMenu#??[  6   $??2??68   .+?5      ?? -   5        $
??Btn1??5      $??Горячее??5      $y?Hidden=?5        ButtonHeader#??[ 5      ?? 5      -   5        $
??Btn2??5      $??Закуски??5      $y?Hidden=?5      #??[ 5      ?? 5      -   5        $
??Btn3??5      $??Супы??5      $y?Hidden=?5      #??[ 5       ?? 5!      -   5        $
??Btn4??5"      $??Салаты??5!      $y?Hidden=?5#      #??[ 5$      ?? 5%      -   5        $??
BtnRegistr??5&      $??Регистрация??5%      #??[ 5(      ?? 5)      -   5        $??BtnLogin??5*      $??
Войти??5)      #??[ 5,      ?? 5-      $??/Resources/Icon_Quote.png??6     ImageMenuHeader#??[ 67   5.      ?? 50   
   $??1??6     SpHello#??[ 6"   $??2??6C   $??62,37,62,87q?6W   .+?51      ?? $b??\Добро пожаловать в нашу кухню! Приятного аппетита!??6     TbHello#??[ 6R   ?? 52      $??/Resources/Catering.png??6     
ImageHello#??[ 65   53       ? 56   
   -   5        $??FrmMain??56      $??1??6     ? NavigationUIVisibility$ Hidden=?57      $??2??60   58      59      