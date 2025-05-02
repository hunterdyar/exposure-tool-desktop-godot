using Godot;
using System;

public partial class LabelUpdate : Label
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void _on_iso_on_value_changed(string newValue)
	{
		Text = newValue;
	}

	private void _on_aperture_on_value_changed(string newValue)
	{
		Text = newValue;
	}
	
	private void _on_ss_on_value_changed(string newValue)
	{
		Text = newValue;
	}
}
