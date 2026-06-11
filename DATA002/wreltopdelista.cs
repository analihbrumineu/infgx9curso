/*
               File: RelTopDeLista
        Description: Relatório de topo de lista.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:25.75
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
   public class wreltopdelista : GXWorkpanel
   {
      public wreltopdelista( int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public wreltopdelista( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public wreltopdelista( IGxContext context ,
                             int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public override String getObjectName( )
      {
         return "RelTopDeLista" ;
      }

      public override String getFrmTitle( )
      {
         return "Relatório de topo de lista" ;
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
         return 637 ;
      }

      public override int getFrmHeight( )
      {
         return 247 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WRelTopDeLista.htm";
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
         /* Execute user event: E11V2M2 */
         E11V2M2 ();
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
         /* Execute user event: E12V2M2 */
         E12V2M2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2M2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV5DatInic = DateTimeUtil.CToD( "01/04/2026", 2) ;
         edtavDatinicial.setValue(AV5DatInic);
         AV6DatFina = Gx_date ;
         edtavDatfinal.setValue(AV6DatFina);
         AV7Selecao = 9999999999L ;
         edtavSelecao.setValue(AV7Selecao);
      }

      protected void E13V2M2( )
      {
         eventLevelContext();
         /* 'Imprimir' Routine */
         if ( ( AV6DatFina < AV5DatInic ) )
         {
            GXutil.msg( me(), "O final do período não pode ocorrer antes do início." );
         }
         else
         {
            if ( ( AV6DatFina > Gx_date ) )
            {
               GXutil.msg( me(), "Não é possível consultar locações futuras." );
            }
            else
            {
               if ( ( AV7Selecao <= 0 ) )
               {
                  GXutil.msg( me(), "Seleção inválida!" );
               }
               else
               {
                  if ( ( AV8Relator == 1 ) && ( AV9Assunto == 1 ) )
                  {
                     new rreltopdelisdevporcliente(context, base.remoteHandle, base.context).execute(  AV5DatInic,  AV6DatFina,  AV7Selecao) ;
                  }
                  if ( ( AV8Relator == 1 ) && ( AV9Assunto == 2 ) )
                  {
                     new rreltopdelisdevporfilme(context, base.remoteHandle, base.context).execute(  AV5DatInic,  AV6DatFina,  AV7Selecao) ;
                  }
                  if ( ( AV8Relator == 1 ) && ( AV9Assunto == 3 ) )
                  {
                     new rreltopdelisdevporcategoria(context, base.remoteHandle, base.context).execute(  AV5DatInic,  AV6DatFina,  AV7Selecao) ;
                  }
                  if ( ( AV8Relator == 1 ) && ( AV9Assunto == 4 ) )
                  {
                     new rreltopdelisdevportipdemidia(context, base.remoteHandle, base.context).execute(  AV5DatInic,  AV6DatFina,  AV7Selecao) ;
                  }
                  if ( ( AV8Relator == 2 ) && ( AV9Assunto == 1 ) )
                  {
                     new rreltopdeliscanporcliente(context, base.remoteHandle, base.context).execute(  AV5DatInic,  AV6DatFina,  AV7Selecao) ;
                  }
                  if ( ( AV8Relator == 2 ) && ( AV9Assunto == 2 ) )
                  {
                     new rreltopdeliscanporfilme(context, base.remoteHandle, base.context).execute(  AV5DatInic,  AV6DatFina,  AV7Selecao) ;
                  }
                  if ( ( AV8Relator == 2 ) && ( AV9Assunto == 3 ) )
                  {
                     new rreltopdeliscanporcategoria(context, base.remoteHandle, base.context).execute(  AV5DatInic,  AV6DatFina,  AV7Selecao) ;
                  }
                  if ( ( AV8Relator == 2 ) && ( AV9Assunto == 4 ) )
                  {
                     new rreltopdeliscanportipdemidia(context, base.remoteHandle, base.context).execute(  AV5DatInic,  AV6DatFina,  AV7Selecao) ;
                  }
               }
            }
         }
         eventLevelResetContext();
      }

      protected void nextLoad( )
      {
      }

      protected void E11V2M2( )
      {
         /* Load Routine */
         nextLoad();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 637 , 247 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavDatinicial = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),186, 66, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 186 , 66 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5DatInic" );
         ((GXEdit) edtavDatinicial.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavDatinicial.addFocusListener(this);
         edtavDatinicial.getGXComponent().setHelpId("HLP_WRelTopDeLista.htm");
         edtavDatfinal = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),348, 66, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 348 , 66 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6DatFina" );
         ((GXEdit) edtavDatfinal.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavDatfinal.addFocusListener(this);
         edtavDatfinal.getGXComponent().setHelpId("HLP_WRelTopDeLista.htm");
         cmbavRelatorio = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 186 , 91 , 120 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8Relator" );
         ((GXComboBox) cmbavRelatorio.getGXComponent()).addItem( new java.lang.Short(1),"Devoluções");
         ((GXComboBox) cmbavRelatorio.getGXComponent()).addItem( new java.lang.Short(2),"Cancelamentos");
         cmbavRelatorio.addFocusListener(this);
         cmbavRelatorio.addItemListener(this);
         cmbavRelatorio.getGXComponent().setHelpId("HLP_WRelTopDeLista.htm");
         cmbavAssunto = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 348 , 91 , 124 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9Assunto" );
         ((GXComboBox) cmbavAssunto.getGXComponent()).addItem( new java.lang.Short(1),"clientes");
         ((GXComboBox) cmbavAssunto.getGXComponent()).addItem( new java.lang.Short(2),"filmes");
         ((GXComboBox) cmbavAssunto.getGXComponent()).addItem( new java.lang.Short(3),"categorias");
         ((GXComboBox) cmbavAssunto.getGXComponent()).addItem( new java.lang.Short(4),"formato de mídia");
         cmbavAssunto.addFocusListener(this);
         cmbavAssunto.addItemListener(this);
         cmbavAssunto.getGXComponent().setHelpId("HLP_WRelTopDeLista.htm");
         edtavSelecao = new GUIObjectLong ( new GXEdit(10, "ZZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),186, 117, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 186 , 117 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7Selecao" );
         ((GXEdit) edtavSelecao.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavSelecao.addFocusListener(this);
         edtavSelecao.getGXComponent().setHelpId("HLP_WRelTopDeLista.htm");
         bttbtt12 = UIFactory.getGXButton( GXPanel1 , "Imprimir" ,  442 ,  169 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt12.setTooltip("Imprimir");
         bttbtt12.addActionListener(this);
         bttbtt12.setFiresEvents(false);
         lbllbl2 = UIFactory.getLabel(GXPanel1, "De", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 119 , 70 , 17 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 316 , 70 , 19 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Assunto", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 119 , 95 , 46 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "por", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 316 , 95 , 19 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Seleção", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 119 , 121 , 47 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavDatinicial ,
                   edtavDatfinal ,
                   cmbavRelatorio ,
                   cmbavAssunto ,
                   edtavSelecao ,
                   bttbtt12
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(edtavDatinicial, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void VariablesToControls( )
      {
         edtavDatinicial.setValue( AV5DatInic );
         edtavDatfinal.setValue( AV6DatFina );
         edtavSelecao.setValue( AV7Selecao );
         cmbavRelatorio.setValue( AV8Relator );
         cmbavAssunto.setValue( AV9Assunto );
      }

      public override void ControlsToVariables( )
      {
         AV5DatInic = (DateTime)(edtavDatinicial.getValue()) ;
         edtavDatinicial.setValue(AV5DatInic);
         AV6DatFina = (DateTime)(edtavDatfinal.getValue()) ;
         edtavDatfinal.setValue(AV6DatFina);
         AV7Selecao = (long)(edtavSelecao.getValue()) ;
         edtavSelecao.setValue(AV7Selecao);
         AV8Relator = (short)(cmbavRelatorio.getValue()) ;
         cmbavRelatorio.setValue(AV8Relator);
         AV9Assunto = (short)(cmbavAssunto.getValue()) ;
         cmbavAssunto.setValue(AV9Assunto);
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
         if ( bttbtt12.isEventSource(eventSource) ) {
            /* Execute user event: E13V2M2 */
            E13V2M2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavDatinicial.isEventSource(eventSource) ) {
            setGXCursor( edtavDatinicial.getGXCursor() );
            return;
         }
         if ( edtavDatfinal.isEventSource(eventSource) ) {
            setGXCursor( edtavDatfinal.getGXCursor() );
            return;
         }
         if ( edtavSelecao.isEventSource(eventSource) ) {
            setGXCursor( edtavSelecao.getGXCursor() );
            return;
         }
         if ( cmbavRelatorio.isEventSource(eventSource) ) {
            setGXCursor( cmbavRelatorio.getGXCursor() );
            return;
         }
         if ( cmbavAssunto.isEventSource(eventSource) ) {
            setGXCursor( cmbavAssunto.getGXCursor() );
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
         if ( edtavDatinicial.isEventSource(eventSource) ) {
            AV5DatInic = edtavDatinicial.getValue() ;
            return;
         }
         if ( edtavDatfinal.isEventSource(eventSource) ) {
            AV6DatFina = edtavDatfinal.getValue() ;
            return;
         }
         if ( edtavSelecao.isEventSource(eventSource) ) {
            AV7Selecao = edtavSelecao.getValue() ;
            return;
         }
         if ( cmbavRelatorio.isEventSource(eventSource) ) {
            AV8Relator = cmbavRelatorio.getValue() ;
            return;
         }
         if ( cmbavAssunto.isEventSource(eventSource) ) {
            AV9Assunto = cmbavAssunto.getValue() ;
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
         AV5DatInic = (DateTime)(DateTime.MinValue) ;
         AV6DatFina = (DateTime)(DateTime.MinValue) ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         AV7Selecao = 0 ;
         AV8Relator = 0 ;
         AV9Assunto = 0 ;
         Gx_date = DateTimeUtil.Today( ) ;
         reloadDynamicLists(0);
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      protected short AV8Relator ;
      protected short AV9Assunto ;
      protected long AV7Selecao ;
      protected DateTime AV5DatInic ;
      protected DateTime AV6DatFina ;
      protected DateTime Gx_date ;
      protected bool returnInSub ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectDatetime edtavDatinicial ;
      protected GUIObjectDatetime edtavDatfinal ;
      protected GUIObjectShort cmbavRelatorio ;
      protected GUIObjectShort cmbavAssunto ;
      protected GUIObjectLong edtavSelecao ;
      protected IGXButton bttbtt12 ;
      protected ILabel lbllbl2 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl8 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl6 ;
   }

}
