﻿namespace BlackjackConsoleGame;

public class Player : Hand
{
	private int _points;
	private int _activeBet;

	public int Points => _points;

	private const int StartingPoints = 100;

	public Player()
	{
		_points = StartingPoints;
	}

	public override string ToString()
	{
		return $"Points: {Points}, Current Bet: {_activeBet},\n{base.ToString()}";
	}

	public bool CanBet(int minimum) => _points >= minimum;

	public void MakeBet(int amount)
	{
		_activeBet = Math.Min(amount, _points);
		_points -= _activeBet;
	}
	public void LoseBet()
	{
		_activeBet = 0;
	}
	public void RefundBet()
	{
		_points += _activeBet;
		_activeBet = 0;
	}
	public void WinBet()
	{
		_points += _activeBet * 2;
		_activeBet = 0;
	}
}