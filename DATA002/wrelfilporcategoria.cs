/*
               File: RelFilPorCategoria
        Description: Impressão de relatório de filmes por categoria.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 11:31:35.65
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
   public class wrelfilporcategoria : GXWorkpanel
   {
      public wrelfilporcategoria( int hnd ,
                                  ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public wrelfilporcategoria( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public wrelfilporcategoria( IGxContext context ,
                                  int hnd ,
                                  ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public override String getObjectName( )
      {
         return "RelFilPorCategoria" ;
      }

      public override String getFrmTitle( )
      {
         return "Relatório de filmes por categoria" ;
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
         return 494 ;
      }

      public override int getFrmHeight( )
      {
         return 247 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WRelFilPorCategoria.htm";
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

      public override void GXStart( )
      {
         /* Execute user event: E12V1Q2 */
         E12V1Q2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V1Q2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV5CatCodI = 1 ;
         edtavCatcodinicial.setValue(AV5CatCodI);
         AV6CatCodF = 999999999 ;
         edtavCatcodfinal.setValue(AV6CatCodF);
         AV7FilCodI = 1 ;
         edtavFilcodinicial.setValue(AV7FilCodI);
         AV8FilCodF = 999999999 ;
         edtavFilcodfinal.setValue(AV8FilCodF);
      }

      protected void E13V1Q2( )
      {
         eventLevelContext();
         /* 'Imprimir' Routine */
         if ( ( AV5CatCodI <= 0 ) || ( AV6CatCodF <= 0 ) || ( AV7FilCodI <= 0 ) || ( AV8FilCodF <= 0 ) )
         {
            GXutil.msg( me(), "Digite um código válido!" );
         }
         else
         {
            if ( ( AV5CatCodI > AV6CatCodF ) || ( AV7FilCodI > AV8FilCodF ) )
            {
               GXutil.msg( me(), "O final do intervalo não pode ocorrer antes do início" );
            }
            else
            {
               new rrelfilporcategoria(context, base.remoteHandle, base.context).execute(  AV5CatCodI,  AV6CatCodF,  AV7FilCodI,  AV8FilCodF) ;
            }
         }
         eventLevelResetContext();
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
         GXPanel1 = new GXPanel(this, 3 , 25 , 494 , 247 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCatcodinicial = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),156, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5CatCodI" );
         ((GXEdit) edtavCatcodinicial.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCatcodinicial.addFocusListener(this);
         edtavCatcodinicial.getGXComponent().setHelpId("HLP_WRelFilPorCategoria.htm");
         edtavCatcodfinal = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),269, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 269 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6CatCodF" );
         ((GXEdit) edtavCatcodfinal.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCatcodfinal.addFocusListener(this);
         edtavCatcodfinal.getGXComponent().setHelpId("HLP_WRelFilPorCategoria.htm");
         edtavFilcodfinal = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),269, 90, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 269 , 90 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8FilCodF" );
         ((GXEdit) edtavFilcodfinal.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFilcodfinal.addFocusListener(this);
         edtavFilcodfinal.getGXComponent().setHelpId("HLP_WRelFilPorCategoria.htm");
         edtavFilcodinicial = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),156, 91, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 91 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7FilCodI" );
         ((GXEdit) edtavFilcodinicial.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFilcodinicial.addFocusListener(this);
         edtavFilcodinicial.getGXComponent().setHelpId("HLP_WRelFilPorCategoria.htm");
         bttbtt10 = UIFactory.getGXButton( GXPanel1 , "Imprimir" ,  251 ,  143 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt10.setTooltip("Imprimir");
         bttbtt10.addActionListener(this);
         bttbtt10.setFiresEvents(false);
         lbllbl2 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 93 , 69 , 55 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 239 , 69 , 19 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 118 , 95 , 30 , 13 );
         lbllbl5 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 239 , 95 , 19 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCatcodinicial ,
                   edtavCatcodfinal ,
                   edtavFilcodfinal ,
                   edtavFilcodinicial ,
                   bttbtt10
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(edtavCatcodinicial, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void VariablesToControls( )
      {
         edtavCatcodinicial.setValue( AV5CatCodI );
         edtavCatcodfinal.setValue( AV6CatCodF );
         edtavFilcodinicial.setValue( AV7FilCodI );
         edtavFilcodfinal.setValue( AV8FilCodF );
      }

      public override void ControlsToVariables( )
      {
         AV5CatCodI = (int)(edtavCatcodinicial.getValue()) ;
         edtavCatcodinicial.setValue(AV5CatCodI);
         AV6CatCodF = (int)(edtavCatcodfinal.getValue()) ;
         edtavCatcodfinal.setValue(AV6CatCodF);
         AV7FilCodI = (int)(edtavFilcodinicial.getValue()) ;
         edtavFilcodinicial.setValue(AV7FilCodI);
         AV8FilCodF = (int)(edtavFilcodfinal.getValue()) ;
         edtavFilcodfinal.setValue(AV8FilCodF);
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
         if ( bttbtt10.isEventSource(eventSource) ) {
            /* Execute user event: E13V1Q2 */
            E13V1Q2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCatcodinicial.isEventSource(eventSource) ) {
            setGXCursor( edtavCatcodinicial.getGXCursor() );
            return;
         }
         if ( edtavCatcodfinal.isEventSource(eventSource) ) {
            setGXCursor( edtavCatcodfinal.getGXCursor() );
            return;
         }
         if ( edtavFilcodinicial.isEventSource(eventSource) ) {
            setGXCursor( edtavFilcodinicial.getGXCursor() );
            return;
         }
         if ( edtavFilcodfinal.isEventSource(eventSource) ) {
            setGXCursor( edtavFilcodfinal.getGXCursor() );
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
         if ( edtavCatcodinicial.isEventSource(eventSource) ) {
            AV5CatCodI = edtavCatcodinicial.getValue() ;
            return;
         }
         if ( edtavCatcodfinal.isEventSource(eventSource) ) {
            AV6CatCodF = edtavCatcodfinal.getValue() ;
            return;
         }
         if ( edtavFilcodinicial.isEventSource(eventSource) ) {
            AV7FilCodI = edtavFilcodinicial.getValue() ;
            return;
         }
         if ( edtavFilcodfinal.isEventSource(eventSource) ) {
            AV8FilCodF = edtavFilcodfinal.getValue() ;
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
         AV5CatCodI = 0 ;
         AV6CatCodF = 0 ;
         AV7FilCodI = 0 ;
         AV8FilCodF = 0 ;
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV5CatCodI ;
      protected int AV6CatCodF ;
      protected int AV7FilCodI ;
      protected int AV8FilCodF ;
      protected bool returnInSub ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCatcodinicial ;
      protected GUIObjectInt edtavCatcodfinal ;
      protected GUIObjectInt edtavFilcodfinal ;
      protected GUIObjectInt edtavFilcodinicial ;
      protected IGXButton bttbtt10 ;
      protected ILabel lbllbl2 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl5 ;
   }

}
