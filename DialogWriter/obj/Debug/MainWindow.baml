   M S B A M L   `   `   `  ����G  CDialogWriter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DialogWriterDialogWriter  5   	       DialogWriter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DialogWriter     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   o� $��2��6   $��0��6#   $��Stretch=�60   .@�5      m� $��Load from file��6   m� 5      $��Save to file��6   5      �� 5   
   $��2��6   $��1��6+   .��5      �� -   5         ��Name$ dialogslist��5         TemplateSelector#��[  6O   $��Stretch=�6�   $��Stretch=�6�   $��2��6�   $��0��6�   ��6+   �� *dialognodes+6�   5      �� 5   
   -   5        $��
Add dialog��5      $��0��6'   $��2��67   $��20��6D   $	��100��6P   $��10q�6_   6k   �� 5   
   -   5        $��
Add answer��5      $��1��6&   $��2��66   $��20��6C   $	��100��6O   $��10q�6^   6j   5      5      