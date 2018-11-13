using ComRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HdlChessUnit
{
	class Program
	{
		static void Main(string[] args)
		{
			var chess = ShellExcute.ShellExcuteExe("ChessProgram14.exe", null, @"D:\Program Files\ChessBase\ChessProgram14");
			do
			{
				Thread.Sleep(10);
			} while (chess.MainWindowHandle == IntPtr.Zero);
			var tar = new WinMessager(chess.MainWindowHandle);
			Thread.Sleep(100);

			tar.FirstChildWindow();
			var board = tar.GetTarget(IntPtr.Zero, "Afx:0000000140000000:8:0000000000000000:0000000000000006:0000000000000000", "");
			board= tar.GetTarget(board.Target, "Afx:0000000140000000:8:0000000000000000:0000000000000006:0000000000000000", "");
			tar.SetText("2333");
			tar.SndMsg(WinMessager.WM_RBUTTONDOWN, IntPtr.Zero, new StringBuilder());
		}
		
	}
}
