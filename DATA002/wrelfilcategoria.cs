/*
               File: RelFilCategoria
        Description: Impressão de relatório de filmes por categoria.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 4/27/2026 11:15:57.41
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
   public class wrelfilcategoria : GXWorkpanel
   {
      public wrelfilcategoria( int hnd ,
                               ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public wrelfilcategoria( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public wrelfilcategoria( IGxContext context ,
                               int hnd ,
                               ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public override String getObjectName( )
      {
         return "RelFilCategoria" ;
      }

      public override String getFrmTitle( )
      {
         return "Impressão de relatório de filmes por categoria." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return ApplicationUI.getDefaultMenuBar(this) ;
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
         return 429 ;
      }

      public override int getFrmHeight( )
      {
         return 182 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WRelFilCategoria.htm";
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
         /* Execute user event: E11V1Q2 */
         E11V1Q2 ();
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

      protected void E12V1Q2( )
      {
         eventLevelContext();
         /* 'Imprimir' Routine */
         new rrelfilcategoria(context, base.remoteHandle, base.context).execute( ) ;
      }

      protected void nextLoad( )
      {
      }

      protected void E11V1Q2( )
      {
         /* Load Routine */
         nextLoad();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 429 , 182 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCatcodigoini = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),156, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5CatCodi" );
         ((GXEdit) edtavCatcodigoini.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCatcodigoini.addFocusListener(this);
         edtavCatcodigoini.getGXComponent().setHelpId("HLP_WRelFilCategoria.htm");
         edtavCatcodigofin = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),260, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 260 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6CatCodi" );
         ((GXEdit) edtavCatcodigofin.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCatcodigofin.addFocusListener(this);
         edtavCatcodigofin.getGXComponent().setHelpId("HLP_WRelFilCategoria.htm");
         edtavFilcodigoini = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),156, 91, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 91 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7FilCodi" );
         ((GXEdit) edtavFilcodigoini.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFilcodigoini.addFocusListener(this);
         edtavFilcodigoini.getGXComponent().setHelpId("HLP_WRelFilCategoria.htm");
         edtavFilcodigofin = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),260, 91, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 260 , 91 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8FilCodi" );
         ((GXEdit) edtavFilcodigofin.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFilcodigofin.addFocusListener(this);
         edtavFilcodigofin.getGXComponent().setHelpId("HLP_WRelFilCategoria.htm");
         bttbtt2 = UIFactory.getGXButton( GXPanel1 , "Imprimir" ,  286 ,  130 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt2.setTooltip("Imprimir");
         bttbtt2.addActionListener(this);
         bttbtt2.setFiresEvents(false);
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Impressão de relatório de filmes por categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 259 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Categorias", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 91 , 65 , 61 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 234 , 65 , 19 , 13 );
         lbllbl5 = UIFactory.getLabel(GXPanel1, "Filmes", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 91 , 91 , 36 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 234 , 91 , 19 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCatcodigoini ,
                   edtavCatcodigofin ,
                   edtavFilcodigoini ,
                   edtavFilcodigofin ,
                   bttbtt2
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(edtavCatcodigoini, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void VariablesToControls( )
      {
         edtavCatcodigoini.setValue( AV5CatCodi );
         edtavCatcodigofin.setValue( AV6CatCodi );
         edtavFilcodigoini.setValue( AV7FilCodi );
         edtavFilcodigofin.setValue( AV8FilCodi );
      }

      public override void ControlsToVariables( )
      {
         AV5CatCodi = (int)(edtavCatcodigoini.getValue()) ;
         edtavCatcodigoini.setValue(AV5CatCodi);
         AV6CatCodi = (int)(edtavCatcodigofin.getValue()) ;
         edtavCatcodigofin.setValue(AV6CatCodi);
         AV7FilCodi = (int)(edtavFilcodigoini.getValue()) ;
         edtavFilcodigoini.setValue(AV7FilCodi);
         AV8FilCodi = (int)(edtavFilcodigofin.getValue()) ;
         edtavFilcodigofin.setValue(AV8FilCodi);
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
         if ( bttbtt2.isEventSource(eventSource) ) {
            /* Execute user event: E12V1Q2 */
            E12V1Q2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCatcodigoini.isEventSource(eventSource) ) {
            setGXCursor( edtavCatcodigoini.getGXCursor() );
            return;
         }
         if ( edtavCatcodigofin.isEventSource(eventSource) ) {
            setGXCursor( edtavCatcodigofin.getGXCursor() );
            return;
         }
         if ( edtavFilcodigoini.isEventSource(eventSource) ) {
            setGXCursor( edtavFilcodigoini.getGXCursor() );
            return;
         }
         if ( edtavFilcodigofin.isEventSource(eventSource) ) {
            setGXCursor( edtavFilcodigofin.getGXCursor() );
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
         if ( edtavCatcodigoini.isEventSource(eventSource) ) {
            AV5CatCodi = edtavCatcodigoini.getValue() ;
            return;
         }
         if ( edtavCatcodigofin.isEventSource(eventSource) ) {
            AV6CatCodi = edtavCatcodigofin.getValue() ;
            return;
         }
         if ( edtavFilcodigoini.isEventSource(eventSource) ) {
            AV7FilCodi = edtavFilcodigoini.getValue() ;
            return;
         }
         if ( edtavFilcodigofin.isEventSource(eventSource) ) {
            AV8FilCodi = edtavFilcodigofin.getValue() ;
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
         AV5CatCodi = 0 ;
         AV6CatCodi = 0 ;
         AV7FilCodi = 0 ;
         AV8FilCodi = 0 ;
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV5CatCodi ;
      protected int AV6CatCodi ;
      protected int AV7FilCodi ;
      protected int AV8FilCodi ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCatcodigoini ;
      protected GUIObjectInt edtavCatcodigofin ;
      protected GUIObjectInt edtavFilcodigoini ;
      protected GUIObjectInt edtavFilcodigofin ;
      protected IGXButton bttbtt2 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl5 ;
      protected ILabel lbllbl6 ;
   }

}
