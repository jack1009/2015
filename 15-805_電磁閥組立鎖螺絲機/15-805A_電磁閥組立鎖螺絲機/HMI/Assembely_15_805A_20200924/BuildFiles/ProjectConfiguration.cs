//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	
	
	public partial class ProjectConfiguration : Neo.ApplicationFramework.Tools.ProjectConfiguration.ProjectConfiguration
	{
		
		public ProjectConfiguration()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		private void InitializeComponent()
		{
			Neo.ApplicationFramework.Tools.ProjectConfiguration.FontSettings fontsettings1 = new Neo.ApplicationFramework.Tools.ProjectConfiguration.FontSettings();
			Neo.ApplicationFramework.Tools.ProjectConfiguration.FontSettings fontsettings2 = new Neo.ApplicationFramework.Tools.ProjectConfiguration.FontSettings();
			// 
			// ProjectConfiguration
			// 
			this.UISettings.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalBottomToTop);
			this.UISettings.ControlBackground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalBottomToTop);
			this.UISettings.ControlForeground = System.Drawing.Color.White;
			fontsettings1.FamilyName = "新細明體";
			fontsettings1.SizePixels = 24;
			this.UISettings.Font = fontsettings1;
			this.UISettings.Foreground = System.Drawing.Color.Black;
			this.UISettings.ListItemHeight = 35;
			this.UISettings.MessageBoxDelay = System.TimeSpan.Parse("00:00:20");
			fontsettings2.FamilyName = "新細明體";
			fontsettings2.SizePixels = 22;
			this.UISettings.TitleFont = fontsettings2;
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public override void ConnectDataBindings()
		{
			base.ConnectDataBindings();
		}
		
		private void InitializeObjectCreations()
		{
		}
		
		private void InitializeBeginInits()
		{
		}
		
		private void InitializeEndInits()
		{
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(ProjectConfiguration));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
