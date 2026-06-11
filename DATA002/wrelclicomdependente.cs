/*
               File: RelCliComDependente
        Description: Impressão de relatório de clientes com dependentes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:25.70
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
   public class wrelclicomdependente : GXWorkpanel
   {
      public wrelclicomdependente( int hnd ,
                                   ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public wrelclicomdependente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public wrelclicomdependente( IGxContext context ,
                                   int hnd ,
                                   ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public override String getObjectName( )
      {
         return "RelCliComDependente" ;
      }

      public override String getFrmTitle( )
      {
         return "Relatório de clientes com dependentes" ;
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
         return 429 ;
      }

      public override int getFrmHeight( )
      {
         return 182 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WRelCliComDependente.htm";
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
         /* Execute user event: E11V1S2 */
         E11V1S2 ();
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
         /* Execute user event: E12V1S2 */
         E12V1S2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V1S2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV5PesCodI = 1 ;
         edtavPescodinicial.setValue(AV5PesCodI);
         AV6PesCodF = 999999999 ;
         edtavPescodfinal.setValue(AV6PesCodF);
      }

      protected void E13V1S2( )
      {
         eventLevelContext();
         /* 'Imprimir' Routine */
         if ( ( AV5PesCodI <= 0 ) || ( AV6PesCodF <= 0 ) )
         {
            GXutil.msg( me(), "Digite um código válido!" );
         }
         else
         {
            if ( ( AV5PesCodI > AV6PesCodF ) )
            {
               GXutil.msg( me(), "O final do intervalo não pode ocorrer antes do início" );
            }
            else
            {
               new rrelclicomdependente(context, base.remoteHandle, base.context).execute(  AV5PesCodI,  AV6PesCodF) ;
            }
         }
         eventLevelResetContext();
      }

      protected void nextLoad( )
      {
      }

      protected void E11V1S2( )
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
         edtavPescodinicial = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),130, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 130 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5PesCodI" );
         ((GXEdit) edtavPescodinicial.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavPescodinicial.addFocusListener(this);
         edtavPescodinicial.getGXComponent().setHelpId("HLP_WRelCliComDependente.htm");
         edtavPescodfinal = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),234, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 234 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6PesCodF" );
         ((GXEdit) edtavPescodfinal.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavPescodfinal.addFocusListener(this);
         edtavPescodfinal.getGXComponent().setHelpId("HLP_WRelCliComDependente.htm");
         bttbtt6 = UIFactory.getGXButton( GXPanel1 , "Imprimir" ,  273 ,  117 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt6.setTooltip("Imprimir");
         bttbtt6.addActionListener(this);
         bttbtt6.setFiresEvents(false);
         lbllbl2 = UIFactory.getLabel(GXPanel1, "Cliente", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 78 , 69 , 73 , 13 );
         lbllbl5 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 208 , 69 , 19 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavPescodinicial ,
                   edtavPescodfinal ,
                   bttbtt6
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(edtavPescodinicial, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void VariablesToControls( )
      {
         edtavPescodinicial.setValue( AV5PesCodI );
         edtavPescodfinal.setValue( AV6PesCodF );
      }

      public override void ControlsToVariables( )
      {
         AV5PesCodI = (int)(edtavPescodinicial.getValue()) ;
         edtavPescodinicial.setValue(AV5PesCodI);
         AV6PesCodF = (int)(edtavPescodfinal.getValue()) ;
         edtavPescodfinal.setValue(AV6PesCodF);
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
         if ( bttbtt6.isEventSource(eventSource) ) {
            /* Execute user event: E13V1S2 */
            E13V1S2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavPescodinicial.isEventSource(eventSource) ) {
            setGXCursor( edtavPescodinicial.getGXCursor() );
            return;
         }
         if ( edtavPescodfinal.isEventSource(eventSource) ) {
            setGXCursor( edtavPescodfinal.getGXCursor() );
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
         if ( edtavPescodinicial.isEventSource(eventSource) ) {
            AV5PesCodI = edtavPescodinicial.getValue() ;
            return;
         }
         if ( edtavPescodfinal.isEventSource(eventSource) ) {
            AV6PesCodF = edtavPescodfinal.getValue() ;
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
         AV5PesCodI = 0 ;
         AV6PesCodF = 0 ;
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV5PesCodI ;
      protected int AV6PesCodF ;
      protected bool returnInSub ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavPescodinicial ;
      protected GUIObjectInt edtavPescodfinal ;
      protected IGXButton bttbtt6 ;
      protected ILabel lbllbl2 ;
      protected ILabel lbllbl5 ;
   }

}
