//<Window x:Class="EDSLGUI.MainWindow"
//        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
//        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
//        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
//        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
//        xmlns:local="clr-namespace:EDSLGUI"
//        mc:Ignorable="d"
//        Title="MainWindow" Height="450" Width="800">
//    <Grid>
//        <Grid.ColumnDefinitions>
//            <ColumnDefinition Width = "155" />
//            < ColumnDefinition />
//        </ Grid.ColumnDefinitions >
//        < TabControl TabStripPlacement="Left" Grid.ColumnSpan="2">
//            <TabItem Height = "50" Width="150" Header="Season" Grid.ColumnSpan="1">
//                <Grid>
//                    <Grid.RowDefinitions>
//                        <RowDefinition></RowDefinition>
//                        <RowDefinition></RowDefinition>
//                        <RowDefinition></RowDefinition>
//                        <RowDefinition></RowDefinition>
//                    </Grid.RowDefinitions>
//                    <StackPanel>
//                        <TextBlock Background = "Gray" Height="30" VerticalAlignment="Top" TextAlignment="Center" Grid.Row="0">Manage Season</TextBlock>
  
//                        <StackPanel HorizontalAlignment = "Center" Orientation= "Horizontal" Margin= "10" >
  
//                              < Label Padding= "0, 0, 80, 0" > Create New Season</Label>
//                            <Label Padding = "80, 0, 0, 0" > View Previous Season</Label>
//                        </StackPanel>
//                        <StackPanel>
//                            <ComboBox Name = "viewseasoncb" Grid.Column= "1" Margin= "0,0,40,0" Width= "85" HorizontalAlignment= "Right" >
  
//                                  < ComboBoxItem VerticalAlignment= "Center" > 2017 </ ComboBoxItem >
  
//                                  < ComboBoxItem VerticalAlignment= "Center" > 2016 </ ComboBoxItem >
  
//                                  < ComboBoxItem VerticalAlignment= "Center" > 2015 </ ComboBoxItem >
  
//                                  < ComboBoxItem VerticalAlignment= "Center" > 2014 </ ComboBoxItem >
  
//                                  < ComboBoxItem VerticalAlignment= "Center" > 2013 </ ComboBoxItem >
  
//                                  < ComboBoxItem VerticalAlignment= "Center" > 2012 </ ComboBoxItem >
  
//                                  < ComboBoxItem VerticalAlignment= "Center" > 2011 </ ComboBoxItem >
  
//                              </ ComboBox >
  

//                              < ComboBox Name= "viewseasondivcb" Margin= "0,10,40,0" Width= "85" HorizontalAlignment= "Right" >
  
//                                  < ComboBoxItem VerticalAlignment= "Center" > Division A</ComboBoxItem>
//                                  <ComboBoxItem VerticalAlignment = "Center" > Division B</ComboBoxItem>
//                                  <ComboBoxItem VerticalAlignment = "Center" > Division C</ComboBoxItem>
//                              </ComboBox>
//                            <Button Margin = "0,10,40,0" HorizontalAlignment= "Right" Width= "85" > GO </ Button >
  
//                          </ StackPanel >
  

//                      </ StackPanel >
  

//                      < TextBlock Background= "Gray" Height= "30" VerticalAlignment= "Top" TextAlignment= "Center" Grid.Row= "2" > Setup Draw</TextBlock>
                      
//                    <StackPanel Grid.Row= "3" >
  
//                      < Label Content= "Select Division" Grid.Row= "3" HorizontalAlignment= "Left" Margin= "0, -50, 0, 0" ></ Label >
  
//                      < ComboBox Grid.Row= "3" Width= "120" Height= "45" HorizontalAlignment= "Left" Margin= "120, -50, 0, 0" >
  
//                          < ComboBoxItem > Div A</ComboBoxItem>
//                          <ComboBoxItem>Div B</ComboBoxItem>
//                        <ComboBoxItem>Div C</ComboBoxItem>
//                    </ComboBox>
//                        <Button HorizontalAlignment = "Right" Width= "75" Height= "45" Margin= "0, -50, 35, 0" > Create Draw</Button>
//                          <Button HorizontalAlignment = "Right" Width= "75" Height= "45" Margin= "0, -50, 120, 0" > View Draw</Button>
//                      </StackPanel>

//                </Grid>
//            </TabItem>
//            <TabItem Height = "50" Header= "Results" >
  
//                  < Grid >
  
//                      < Grid.RowDefinitions >
  
//                          < RowDefinition ></ RowDefinition >
  
//                          < RowDefinition ></ RowDefinition >
  
//                      </ Grid.RowDefinitions >
  
//                      < TextBlock Background= "Gray" Height= "40" VerticalAlignment= "Top" TextAlignment= "Center" > View Results</TextBlock>
//                  </Grid>
//            </TabItem>
//            <TabItem Height = "50" Header= "Clubs" >
  
//                  < Grid >
  
//                      < Grid.RowDefinitions >
  
//                          < RowDefinition ></ RowDefinition >
  
//                          < RowDefinition ></ RowDefinition >
  
//                      </ Grid.RowDefinitions >
  
//                      < TextBlock Background= "Gray" Height= "40" VerticalAlignment= "Top" TextAlignment= "Center" > Manage Clubs</TextBlock>
//                  </Grid>
//            </TabItem>
//            <TabItem Height = "50" Header= "Teams" >
  
//                  < Grid >
  
//                      < Grid.RowDefinitions >
  
//                          < RowDefinition ></ RowDefinition >
  
//                          < RowDefinition ></ RowDefinition >
  
//                      </ Grid.RowDefinitions >
  
//                      < TextBlock Background= "Gray" Height= "40" VerticalAlignment= "Top" TextAlignment= "Center" > Manage Teams</TextBlock>
//                  </Grid>
//            </TabItem>
//            <TabItem Height = "50" Header= "Players" >
  
//                  < Grid >
  
//                      < Grid.RowDefinitions >
  
//                          < RowDefinition Height= "206*" ></ RowDefinition >
  
//                          < RowDefinition Height= "207*" ></ RowDefinition >
  
//                      </ Grid.RowDefinitions >
  
//                      < TextBlock Background= "Gray" Height= "40" VerticalAlignment= "Top" TextAlignment= "Center" > Manage Players</TextBlock>
//                  </Grid>
//            </TabItem>
//            <TabItem Height = "50" Header= "Reports" >
  
//                  < Grid >
  
//                      < Grid.RowDefinitions >
  
//                          < RowDefinition ></ RowDefinition >
  
//                          < RowDefinition ></ RowDefinition >
  
//                      </ Grid.RowDefinitions >
  
//                      < TextBlock Background= "Gray" Height= "40" VerticalAlignment= "Top" TextAlignment= "Center" > Create Reports</TextBlock>
//                  </Grid>
//            </TabItem>
//        </TabControl>
//    </Grid>
//</Window>
