﻿using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
	public BMIResultRepository bMI { get; set; }
	
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		BMIResultRepository bMIResultRepository = bMI;
	}
}
