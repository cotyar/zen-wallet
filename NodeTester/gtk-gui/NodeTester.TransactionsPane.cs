
// This file has been generated by the GUI designer. Do not modify.
namespace NodeTester
{
	public partial class TransactionsPane
	{
		private global::Gtk.Notebook notebook2;

		private global::Gtk.Notebook notebook3;

		private global::Gtk.VBox vbox1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gtk.TreeView treeviewKeysUnused;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonKeyCreate;

		private global::Gtk.Label label4;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::Gtk.TreeView treeviewKeysUsed;

		private global::Gtk.Label label5;

		private global::Gtk.ScrolledWindow GtkScrolledWindow3;

		private global::Gtk.TreeView treeviewKeysChange;

		private global::Gtk.Label label7;

		private global::Gtk.Label label2;

		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow4;

		private global::Gtk.TreeView treeviewTransactions;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonMine;

		private global::Gtk.Label label1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Table table3;

		private global::Gtk.ComboBoxEntry comboboxentry1;

		private global::Gtk.Entry entryTransactionSendAmount;

		private global::Gtk.Entry entryTransactionSendTo;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label12;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonTransactionSend;

		private global::Gtk.Button buttonTransactionPreview;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeviewTransactionItems;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonTransactionRemove;

		private global::Gtk.Label label3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget NodeTester.TransactionsPane
			global::Stetic.BinContainer.Attach(this);
			this.Name = "NodeTester.TransactionsPane";
			// Container child NodeTester.TransactionsPane.Gtk.Container+ContainerChild
			this.notebook2 = new global::Gtk.Notebook();
			this.notebook2.CanFocus = true;
			this.notebook2.Name = "notebook2";
			this.notebook2.CurrentPage = 1;
			this.notebook2.BorderWidth = ((uint)(5));
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.notebook3 = new global::Gtk.Notebook();
			this.notebook3.CanFocus = true;
			this.notebook3.Name = "notebook3";
			this.notebook3.CurrentPage = 2;
			this.notebook3.BorderWidth = ((uint)(5));
			// Container child notebook3.Gtk.Notebook+NotebookChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(5));
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeviewKeysUnused = new global::Gtk.TreeView();
			this.treeviewKeysUnused.CanFocus = true;
			this.treeviewKeysUnused.Name = "treeviewKeysUnused";
			this.GtkScrolledWindow1.Add(this.treeviewKeysUnused);
			this.vbox1.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow1]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonKeyCreate = new global::Gtk.Button();
			this.buttonKeyCreate.CanFocus = true;
			this.buttonKeyCreate.Name = "buttonKeyCreate";
			this.buttonKeyCreate.UseUnderline = true;
			this.buttonKeyCreate.Label = global::Mono.Unix.Catalog.GetString("Create");
			this.hbox2.Add(this.buttonKeyCreate);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonKeyCreate]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.notebook3.Add(this.vbox1);
			// Notebook tab
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Unsed");
			this.notebook3.SetTabLabel(this.vbox1, this.label4);
			this.label4.ShowAll();
			// Container child notebook3.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow2.BorderWidth = ((uint)(5));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.treeviewKeysUsed = new global::Gtk.TreeView();
			this.treeviewKeysUsed.CanFocus = true;
			this.treeviewKeysUsed.Name = "treeviewKeysUsed";
			this.GtkScrolledWindow2.Add(this.treeviewKeysUsed);
			this.notebook3.Add(this.GtkScrolledWindow2);
			global::Gtk.Notebook.NotebookChild w7 = ((global::Gtk.Notebook.NotebookChild)(this.notebook3[this.GtkScrolledWindow2]));
			w7.Position = 1;
			// Notebook tab
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Used");
			this.notebook3.SetTabLabel(this.GtkScrolledWindow2, this.label5);
			this.label5.ShowAll();
			// Container child notebook3.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow3.BorderWidth = ((uint)(5));
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.treeviewKeysChange = new global::Gtk.TreeView();
			this.treeviewKeysChange.CanFocus = true;
			this.treeviewKeysChange.Name = "treeviewKeysChange";
			this.GtkScrolledWindow3.Add(this.treeviewKeysChange);
			this.notebook3.Add(this.GtkScrolledWindow3);
			global::Gtk.Notebook.NotebookChild w9 = ((global::Gtk.Notebook.NotebookChild)(this.notebook3[this.GtkScrolledWindow3]));
			w9.Position = 2;
			// Notebook tab
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Change");
			this.notebook3.SetTabLabel(this.GtkScrolledWindow3, this.label7);
			this.label7.ShowAll();
			this.notebook2.Add(this.notebook3);
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Keys");
			this.notebook2.SetTabLabel(this.notebook3, this.label2);
			this.label2.ShowAll();
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			this.treeviewTransactions = new global::Gtk.TreeView();
			this.treeviewTransactions.CanFocus = true;
			this.treeviewTransactions.Name = "treeviewTransactions";
			this.GtkScrolledWindow4.Add(this.treeviewTransactions);
			this.vbox2.Add(this.GtkScrolledWindow4);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow4]));
			w12.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonMine = new global::Gtk.Button();
			this.buttonMine.CanFocus = true;
			this.buttonMine.Name = "buttonMine";
			this.buttonMine.UseUnderline = true;
			this.buttonMine.Label = global::Mono.Unix.Catalog.GetString("Mine");
			this.hbox4.Add(this.buttonMine);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonMine]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.notebook2.Add(this.vbox2);
			global::Gtk.Notebook.NotebookChild w15 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2[this.vbox2]));
			w15.Position = 1;
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Transactions");
			this.notebook2.SetTabLabel(this.vbox2, this.label1);
			this.label1.ShowAll();
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(5));
			// Container child vbox3.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry1.Name = "comboboxentry1";
			this.table3.Add(this.comboboxentry1);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table3[this.comboboxentry1]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryTransactionSendAmount = new global::Gtk.Entry();
			this.entryTransactionSendAmount.CanFocus = true;
			this.entryTransactionSendAmount.Name = "entryTransactionSendAmount";
			this.entryTransactionSendAmount.IsEditable = true;
			this.entryTransactionSendAmount.InvisibleChar = '●';
			this.table3.Add(this.entryTransactionSendAmount);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table3[this.entryTransactionSendAmount]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryTransactionSendTo = new global::Gtk.Entry();
			this.entryTransactionSendTo.CanFocus = true;
			this.entryTransactionSendTo.Name = "entryTransactionSendTo";
			this.entryTransactionSendTo.IsEditable = true;
			this.entryTransactionSendTo.InvisibleChar = '●';
			this.table3.Add(this.entryTransactionSendTo);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table3[this.entryTransactionSendTo]));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 0F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Send To:");
			this.table3.Add(this.label10);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table3[this.label10]));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Asset:");
			this.table3.Add(this.label11);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table3[this.label11]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Amount:");
			this.table3.Add(this.label12);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table3[this.label12]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.table3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.table3]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonTransactionSend = new global::Gtk.Button();
			this.buttonTransactionSend.CanFocus = true;
			this.buttonTransactionSend.Name = "buttonTransactionSend";
			this.buttonTransactionSend.UseUnderline = true;
			this.buttonTransactionSend.Label = global::Mono.Unix.Catalog.GetString("Send");
			this.hbox1.Add(this.buttonTransactionSend);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonTransactionSend]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonTransactionPreview = new global::Gtk.Button();
			this.buttonTransactionPreview.CanFocus = true;
			this.buttonTransactionPreview.Name = "buttonTransactionPreview";
			this.buttonTransactionPreview.UseUnderline = true;
			this.buttonTransactionPreview.Label = global::Mono.Unix.Catalog.GetString("Preview");
			this.hbox1.Add(this.buttonTransactionPreview);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonTransactionPreview]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox3.Add(this.hbox1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewTransactionItems = new global::Gtk.TreeView();
			this.treeviewTransactionItems.CanFocus = true;
			this.treeviewTransactionItems.Name = "treeviewTransactionItems";
			this.GtkScrolledWindow.Add(this.treeviewTransactionItems);
			this.vbox3.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.GtkScrolledWindow]));
			w27.Position = 2;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonTransactionRemove = new global::Gtk.Button();
			this.buttonTransactionRemove.CanFocus = true;
			this.buttonTransactionRemove.Name = "buttonTransactionRemove";
			this.buttonTransactionRemove.UseUnderline = true;
			this.buttonTransactionRemove.Label = global::Mono.Unix.Catalog.GetString("Remove");
			this.hbox3.Add(this.buttonTransactionRemove);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonTransactionRemove]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox3.Add(this.hbox3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			this.notebook2.Add(this.vbox3);
			global::Gtk.Notebook.NotebookChild w30 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2[this.vbox3]));
			w30.Position = 2;
			// Notebook tab
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Send");
			this.notebook2.SetTabLabel(this.vbox3, this.label3);
			this.label3.ShowAll();
			this.Add(this.notebook2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
