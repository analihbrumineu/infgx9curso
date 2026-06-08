/*
               File: RelMid
        Description: Impressão de relatórios de mídia.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/3/2026 10:48:13.53
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class wrelmid : GXWorkpanel
   {
      public wrelmid( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public wrelmid( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public wrelmid( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public override String getObjectName( )
      {
         return "RelMid" ;
      }

      public override String getFrmTitle( )
      {
         return "Relatório de mídia." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return null;
      }

      public override bool useCallersMenuBar( )
      {
         return true;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 605 ;
      }

      public override int getFrmHeight( )
      {
         return 240 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WRelMid.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return IsMain;
      }

      public override bool isModal( )
      {
         return false;
      }

      protected bool hasDBAccess( )
      {
         return false;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
         /* Execute user event: E11V1T2 */
         E11V1T2 ();
      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         standAlone();
         VariablesToControls();
         /* End function GeneXus Refresh */
      }

      public override void GXStart( )
      {
         /* Execute user event: E12V1T2 */
         E12V1T2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V1T2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV5RelMidO = 0 ;
         cmbavRelmidopcao.setValue(AV5RelMidO);
         AV8MidTipo = 0 ;
         cmbavMidtipo.setValue(AV8MidTipo);
         AV6CatCodI = 1 ;
         edtavCatcodinicial.setValue(AV6CatCodI);
         AV7CatCodF = 999999999 ;
         edtavCatcodfinal.setValue(AV7CatCodF);
      }

      protected void E13V1T2( )
      {
         eventLevelContext();
         /* 'Imprimir' Routine */
         if ( ( AV5RelMidO == 0 ) )
         {
            new rrelmidporcategoria(context, base.remoteHandle, base.context).execute(  AV8MidTipo,  AV6CatCodI,  AV7CatCodF) ;
         }
         if ( ( AV5RelMidO == 1 ) )
         {
            new rrelmidporcatfilme(context, base.remoteHandle, base.context).execute(  AV8MidTipo,  AV6CatCodI,  AV7CatCodF) ;
         }
         eventLevelResetContext();
      }

      protected void nextLoad( )
      {
      }

      protected void E11V1T2( )
      {
         /* Load Routine */
         nextLoad();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 605 , 240 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         cmbavRelmidopcao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 159 , 57 , 181 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5RelMidO" );
         ((GXComboBox) cmbavRelmidopcao.getGXComponent()).addItem( new java.lang.Short(0),"Categoria");
         ((GXComboBox) cmbavRelmidopcao.getGXComponent()).addItem( new java.lang.Short(1),"Categoria/filme");
         cmbavRelmidopcao.addFocusListener(this);
         cmbavRelmidopcao.addItemListener(this);
         cmbavRelmidopcao.getGXComponent().setHelpId("HLP_WRelMid.htm");
         cmbavMidtipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 159 , 84 , 68 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8MidTipo" );
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(0),"Todos");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(4),"Box");
         cmbavMidtipo.addFocusListener(this);
         cmbavMidtipo.addItemListener(this);
         cmbavMidtipo.getGXComponent().setHelpId("HLP_WRelMid.htm");
         edtavCatcodinicial = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),159, 111, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 159 , 111 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6CatCodI" );
         ((GXEdit) edtavCatcodinicial.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCatcodinicial.addFocusListener(this);
         edtavCatcodinicial.getGXComponent().setHelpId("HLP_WRelMid.htm");
         edtavCatcodfinal = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),265, 111, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 265 , 111 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7CatCodF" );
         ((GXEdit) edtavCatcodfinal.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCatcodfinal.addFocusListener(this);
         edtavCatcodfinal.getGXComponent().setHelpId("HLP_WRelMid.htm");
         bttbtt8 = UIFactory.getGXButton( GXPanel1 , "Imprimir" ,  429 ,  176 ,  78 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt8.setTooltip("Imprimir");
         bttbtt8.addActionListener(this);
         bttbtt8.setFiresEvents(false);
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Tipo do relatório", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 57 , 61 , 94 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "Tipo da mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 72 , 88 , 79 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 96 , 115 , 55 , 13 );
         lbllbl7 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 239 , 115 , 19 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   cmbavRelmidopcao ,
                   cmbavMidtipo ,
                   edtavCatcodinicial ,
                   edtavCatcodfinal ,
                   bttbtt8
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(cmbavRelmidopcao, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void VariablesToControls( )
      {
         cmbavRelmidopcao.setValue( AV5RelMidO );
         edtavCatcodinicial.setValue( AV6CatCodI );
         edtavCatcodfinal.setValue( AV7CatCodF );
         cmbavMidtipo.setValue( AV8MidTipo );
      }

      public override void ControlsToVariables( )
      {
         AV5RelMidO = (short)(cmbavRelmidopcao.getValue()) ;
         cmbavRelmidopcao.setValue(AV5RelMidO);
         AV6CatCodI = (int)(edtavCatcodinicial.getValue()) ;
         edtavCatcodinicial.setValue(AV6CatCodI);
         AV7CatCodF = (int)(edtavCatcodfinal.getValue()) ;
         edtavCatcodfinal.setValue(AV7CatCodF);
         AV8MidTipo = (short)(cmbavMidtipo.getValue()) ;
         cmbavMidtipo.setValue(AV8MidTipo);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
      }

      protected void eventLevelResetContext( )
      {
      }

      protected void reloadGridRow( )
      {
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt8.isEventSource(eventSource) ) {
            /* Execute user event: E13V1T2 */
            E13V1T2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( cmbavRelmidopcao.isEventSource(eventSource) ) {
            setGXCursor( cmbavRelmidopcao.getGXCursor() );
            return;
         }
         if ( edtavCatcodinicial.isEventSource(eventSource) ) {
            setGXCursor( edtavCatcodinicial.getGXCursor() );
            return;
         }
         if ( edtavCatcodfinal.isEventSource(eventSource) ) {
            setGXCursor( edtavCatcodfinal.getGXCursor() );
            return;
         }
         if ( cmbavMidtipo.isEventSource(eventSource) ) {
            setGXCursor( cmbavMidtipo.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( cmbavRelmidopcao.isEventSource(eventSource) ) {
            AV5RelMidO = cmbavRelmidopcao.getValue() ;
            return;
         }
         if ( edtavCatcodinicial.isEventSource(eventSource) ) {
            AV6CatCodI = edtavCatcodinicial.getValue() ;
            return;
         }
         if ( edtavCatcodfinal.isEventSource(eventSource) ) {
            AV7CatCodF = edtavCatcodfinal.getValue() ;
            return;
         }
         if ( cmbavMidtipo.isEventSource(eventSource) ) {
            AV8MidTipo = cmbavMidtipo.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (triggerEventEnter(eventSource, keyCode)) {
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         stopThreads();
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         returnInSub = false ;
         AV5RelMidO = 0 ;
         AV8MidTipo = 0 ;
         AV6CatCodI = 0 ;
         AV7CatCodF = 0 ;
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV5RelMidO ;
      protected short AV8MidTipo ;
      protected int AV6CatCodI ;
      protected int AV7CatCodF ;
      protected bool returnInSub ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectShort cmbavRelmidopcao ;
      protected GUIObjectShort cmbavMidtipo ;
      protected GUIObjectInt edtavCatcodinicial ;
      protected GUIObjectInt edtavCatcodfinal ;
      protected IGXButton bttbtt8 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl7 ;
   }

}
