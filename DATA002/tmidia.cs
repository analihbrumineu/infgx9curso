/*
               File: Midia
        Description: Cadastro de mídias.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:18:13.16
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
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   /* Client and Server side code */
   public class tmidia : GXTransaction
   {
      public tmidia( int hnd ,
                     ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tmidia( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tmidia( IGxContext context ,
                     int hnd ,
                     ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey069( )
      {
         A116LocCod = 0 ;
         n116LocCod = false ;
         n116LocCod = (((0==A116LocCod)) ? true : false) ;
         A35MidTipo = 1 ;
         n35MidTipo = false ;
         A36MidSitu = 1 ;
         n36MidSitu = false ;
         A28FilCodi = 0 ;
         n28FilCodi = false ;
         n28FilCodi = (((0==A28FilCodi)) ? true : false) ;
         A29FilNome = "" ;
         n29FilNome = false ;
      }

      protected void InitAll069( )
      {
         K37MidCodi = A37MidCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey069( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A116LocCod = i116LocCod ;
         edtLocCodLocCodigo.setValue(A116LocCod);
         n116LocCod = false ;
         A35MidTipo = i35MidTipo ;
         cmbMidTipo.setValue(A35MidTipo);
         n35MidTipo = false ;
         A36MidSitu = i36MidSitu ;
         cmbMidSituacao.setValue(A36MidSitu);
         n36MidSitu = false ;
      }

      protected void ResetCaption060( )
      {
      }

      /* Client side code */
      public override void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
      }

      public override String getObjectName( )
      {
         return "Midia" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de mídias." ;
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
         return 611 ;
      }

      public override int getFrmHeight( )
      {
         return 286 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TMidia.htm";
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
         return true ;
      }

      protected bool hasDBAccess( )
      {
         return true ;
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

      public void execute( int aP0_MidCodigo ,
                           String aP1_Gx_mode )
      {
         this.A37MidCodi = aP0_MidCodigo;
         this.Gx_mode = aP1_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 611 , 286 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtMidCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),169, 78, 91, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 169 , 78 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A37MidCodi" );
         ((GXEdit) edtMidCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtMidCodigo.addFocusListener(this);
         edtMidCodigo.getGXComponent().setHelpId("HLP_TMidia.htm");
         cmbMidTipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 169 , 104 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A35MidTipo" );
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(4),"Box");
         cmbMidTipo.addFocusListener(this);
         cmbMidTipo.addItemListener(this);
         cmbMidTipo.getGXComponent().setHelpId("HLP_TMidia.htm");
         cmbMidSituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 338 , 104 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A36MidSitu" );
         ((GXComboBox) cmbMidSituacao.getGXComponent()).addItem( new java.lang.Short(1),"Liberado");
         ((GXComboBox) cmbMidSituacao.getGXComponent()).addItem( new java.lang.Short(2),"Locado");
         cmbMidSituacao.addFocusListener(this);
         cmbMidSituacao.addItemListener(this);
         cmbMidSituacao.getGXComponent().setHelpId("HLP_TMidia.htm");
         edtFilCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),169, 130, 91, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 169 , 130 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A28FilCodi" );
         ((GXEdit) edtFilCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtFilCodigo.addFocusListener(this);
         edtFilCodigo.getGXComponent().setHelpId("HLP_TMidia.htm");
         edtFilNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),338, 130, 221, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 338 , 130 , 221 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A29FilNome" );
         ((GXEdit) edtFilNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtFilNome.addFocusListener(this);
         edtFilNome.getGXComponent().setHelpId("HLP_TMidia.htm");
         edtLocCodLocCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),247, 184, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 247 , 184 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A116LocCod" );
         ((GXEdit) edtLocCodLocCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtLocCodLocCodigo.addFocusListener(this);
         edtLocCodLocCodigo.getGXComponent().setHelpId("HLP_TMidia.htm");
         bttVislocacao = UIFactory.getGXButton( GXPanel1 , "Visualizar" ,  455 ,  182 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttVislocacao.setTooltip("Visualizar");
         bttVislocacao.addActionListener(this);
         bttVislocacao.setFiresEvents(false);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Enter" ,  455 ,  247 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Enter");
         bttBtn_enter.addActionListener(this);
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Cadastro de mídias", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 110 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 78 , 40 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Tipo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 108 , 26 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 273 , 108 , 51 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "Código do filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 134 , 88 , 13 );
         lbllbl12 = UIFactory.getLabel(GXPanel1, "Título", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 273 , 134 , 35 , 13 );
         lbllbl13 = UIFactory.getLabel(GXPanel1, "Código de locação de mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 78 , 188 , 160 , 13 );
         rctrct16 = UIFactory.getGXRectangle( GXPanel1 , 1 , 65 , 169 , 495 , 53 , Integer.MAX_VALUE , UIFactory.getColor(0) , ILabelConstants.BORDER_SINGLE );
         edtFilCodigo.addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         focusManager.setControlList(new IFocusableControl[] {
                   edtMidCodigo ,
                   cmbMidTipo ,
                   cmbMidSituacao ,
                   edtFilCodigo ,
                   edtFilNome ,
                   edtLocCodLocCodigo ,
                   bttBtn_enter ,
                   bttVislocacao
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Midcodigo();
         setFocus(cmbMidTipo, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey069( ) ;
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setGXEnabled(0);
            edtMidCodigo.setEnabled(0);
            cmbMidTipo.setEnabled(0);
            cmbMidSituacao.setEnabled(0);
            edtFilCodigo.setEnabled(0);
            edtFilNome.setEnabled(0);
            edtLocCodLocCodigo.setEnabled(0);
            setFocus(bttBtn_enter, true);
         }
      }

      public override void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               base.context.msgStatus(GXResourceManager.GetMessage("confdelete"));
            }
            else
            {
               base.context.msgStatus(GXResourceManager.GetMessage("mustconfirm"));
            }
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionconfirm"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionconfirm"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionadd"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionadd"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionupdate"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionupdate"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captiondelete"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captiondelete"));
         }
         else
         {
         }
      }

      protected void AfterTrn( )
      {
         if ( ( trnEnded == 1 ) )
         {
            trnEnded = 0 ;
            if (!cleanedUp) {
               standaloneNotModal( ) ;
               standaloneModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  )
               {
                  /* Clear variables for new insertion. */
                  InitAll069( ) ;
                  standaloneNotModal( ) ;
                  standaloneModal( ) ;
               }
            }
         }
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void GXEnter( )
      {
         btn_enter( ) ;
         if (!cleanedUp) {
            VariablesToControls();
            set_caption( );
         }
      }

      public override void GXStart( )
      {
         standaloneStartup( ) ;
         VariablesToControls();
         /* Execute Start event if defined. */
         /* Execute user event: E11062 */
         E11062 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         lastAnyError = AnyError ;
         AnyError = 0;
         if ( bttBtn_enter.isEventSource(eventSource) ) {
            if ( ( lastAnyError != 0 ) )
            {
               return;
            }
            btn_enter( ) ;
            if (!cleanedUp) {
               VariablesToControls();
               set_caption( );
            }
            return;
         }
         if ( bttVislocacao.isEventSource(eventSource) ) {
            if ( ( lastAnyError != 0 ) )
            {
               return;
            }
            /* Execute user event: E12062 */
            E12062 ();
            if (!cleanedUp) {
               VariablesToControls();
            }
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtMidCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtMidCodigo.getGXCursor() );
            return;
         }
         if ( cmbMidTipo.isEventSource(eventSource) ) {
            setGXCursor( cmbMidTipo.getGXCursor() );
            return;
         }
         if ( cmbMidSituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbMidSituacao.getGXCursor() );
            return;
         }
         if ( edtFilCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtFilCodigo.getGXCursor() );
            return;
         }
         if ( edtFilNome.isEventSource(eventSource) ) {
            setGXCursor( edtFilNome.getGXCursor() );
            return;
         }
         if ( edtLocCodLocCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtLocCodLocCodigo.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( edtLocCodLocCodigo.isEventSource(eventSource) ) {
            Valid_Loccodloccodigo ();
            return;
         }
         if ( edtFilCodigo.isEventSource(eventSource) ) {
            Valid_Filcodigo ();
            return;
         }
         if ( edtMidCodigo.isEventSource(eventSource) ) {
            Valid_Midcodigo ();
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtMidCodigo.isEventSource(eventSource) ) {
            A37MidCodi = edtMidCodigo.getValue() ;
            return;
         }
         if ( cmbMidTipo.isEventSource(eventSource) ) {
            A35MidTipo = cmbMidTipo.getValue() ;
            n35MidTipo = (((0==A35MidTipo)) ? true : false) ;
            return;
         }
         if ( cmbMidSituacao.isEventSource(eventSource) ) {
            A36MidSitu = cmbMidSituacao.getValue() ;
            n36MidSitu = (((0==A36MidSitu)) ? true : false) ;
            return;
         }
         if ( edtFilCodigo.isEventSource(eventSource) ) {
            A28FilCodi = edtFilCodigo.getValue() ;
            n28FilCodi = (((0==A28FilCodi)) ? true : false) ;
            return;
         }
         if ( edtFilNome.isEventSource(eventSource) ) {
            A29FilNome = edtFilNome.getValue() ;
            return;
         }
         if ( edtLocCodLocCodigo.isEventSource(eventSource) ) {
            A116LocCod = edtLocCodLocCodigo.getValue() ;
            n116LocCod = (((0==A116LocCod)) ? true : false) ;
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
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E13062 */
            E13062 ();
            if (!cleanedUp) {
               VariablesToControls();
            }
            return true ;
         }
         if (triggerEventEnter(eventSource, keyCode)) {
            AnyError = 0;
            btn_enter( ) ;
            if (!cleanedUp) {
               VariablesToControls();
               set_caption( );
            }
            return true ;
         }
         if (keyCode == getContext().getClientPreferences().getKEY_PROMPT()) {
            return promptHandler(eventSource);
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "BROWSE".TrimEnd(' ') ) == 0 ) )
         {
            return promptHandler(eventSource) ;
         }
         return false;
      }

      public override bool isKeyControl( Object eventSource )
      {
         if ( ( edtMidCodigo.isEventSource(eventSource) ) && ( ( A37MidCodi != edtMidCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
         if ( ( cmbMidTipo.isEventSource(eventSource) ) && ( ( A35MidTipo != cmbMidTipo.getValue() ) ) )
         {
            return true;
         }
         if ( ( cmbMidSituacao.isEventSource(eventSource) ) && ( ( A36MidSitu != cmbMidSituacao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtFilCodigo.isEventSource(eventSource) ) && ( ( A28FilCodi != edtFilCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtFilNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A29FilNome.TrimEnd(' '), edtFilNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtLocCodLocCodigo.isEventSource(eventSource) ) && ( ( A116LocCod != edtLocCodLocCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public override void resetCaption( )
      {
         ResetCaption060( ) ;
      }

      public override void setAddCaption( )
      {
      }

      public override bool getModeByParameter( )
      {
         return true ;
      }

      public override IGXButton getConfirmButton( )
      {
         return bttBtn_enter ;
      }

      public bool promptHandler( Object eventSource )
      {
         if (( edtFilCodigo.isEventSource(eventSource) ) && ( edtFilCodigo.isEnabled() )) {
            prompt_28_9( ) ;
            return true ;
         }
         return false;
      }

      public override void deleteLineHandler( Object eventSource ,
                                              int row )
      {
      }

      public override void setNoAccept( Object eventSource )
      {
         if ( cmbMidTipo.isEventSource(eventSource) )
         {
            cmbMidTipo.setEnabled(!( ( ( A116LocCod != 0 ) || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  ) || ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ) ));
         }
         if ( edtFilCodigo.isEventSource(eventSource) )
         {
            edtFilCodigo.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      public override void VariablesToControls( )
      {
         edtMidCodigo.setValue( A37MidCodi );
         cmbMidTipo.setValue( A35MidTipo );
         cmbMidSituacao.setValue( A36MidSitu );
         edtFilCodigo.setValue( A28FilCodi );
         edtFilNome.setValue( A29FilNome );
         edtLocCodLocCodigo.setValue( A116LocCod );
      }

      public override void ControlsToVariables( )
      {
         A37MidCodi = (int)(edtMidCodigo.getValue()) ;
         edtMidCodigo.setValue(A37MidCodi);
         A35MidTipo = (short)(cmbMidTipo.getValue()) ;
         cmbMidTipo.setValue(A35MidTipo);
         n35MidTipo = false ;
         n35MidTipo = (((0==A35MidTipo)) ? true : false) ;
         A36MidSitu = (short)(cmbMidSituacao.getValue()) ;
         cmbMidSituacao.setValue(A36MidSitu);
         n36MidSitu = false ;
         n36MidSitu = (((0==A36MidSitu)) ? true : false) ;
         A28FilCodi = (int)(edtFilCodigo.getValue()) ;
         edtFilCodigo.setValue(A28FilCodi);
         n28FilCodi = false ;
         n28FilCodi = (((0==A28FilCodi)) ? true : false) ;
         A29FilNome = (String)(edtFilNome.getValue()) ;
         edtFilNome.setValue(A29FilNome);
         n29FilNome = false ;
         A116LocCod = (int)(edtLocCodLocCodigo.getValue()) ;
         edtLocCodLocCodigo.setValue(A116LocCod);
         n116LocCod = false ;
         n116LocCod = (((0==A116LocCod)) ? true : false) ;
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

      protected void prompt_28_9( )
      {
         new wgx0030(context, base.remoteHandle, base.context).execute( out  A28FilCodi) ;
         edtFilCodigo.setValue( A28FilCodi );
         n28FilCodi = false ;
         setFocus(edtFilCodigo);
         ResetCaption060( ) ;
      }

      protected void Valid_Midcodigo( )
      {
         if ( ( A37MidCodi != K37MidCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K37MidCodi = A37MidCodi ;
               getEqualNoModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
               {
                  StandaloneModalInsert( ) ;
               }
               VariablesToControls();
            }
            if ( ( AnyError == 0 ) )
            {
               geteqAfterKey = 0 ;
            }
            else
            {
               geteqAfterKey = 1 ;
            }
         }
         IsConfirmed = 0 ;
         set_caption( ) ;
      }

      protected void Valid_Filcodigo( )
      {
         /* Using cursor T00062 */
         pr_default.execute(0, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A28FilCodi)) ) )
            {
               GXutil.msg( me(), "Não existe 'Cadastro de filmes.'." );
               AnyError = 1 ;
               setNextFocus( edtFilCodigo );
               setFocusNext();
            }
         }
         A29FilNome = T00062_A29FilNome[0] ;
         n29FilNome = T00062_n29FilNome[0] ;
         pr_default.close(0);
         edtFilNome.setValue( A29FilNome );
         if ( true /* After */ && ((0==A28FilCodi)) )
         {
            GXutil.msg( me(), "Código do filme deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtFilCodigo );
            setFocusNext();
         }
         pr_default.close(0);
      }

      protected void Valid_Loccodloccodigo( )
      {
         reloadGridRow();
      }

      protected void E11062( )
      {
         eventNoLevelContext();
         /* Start Routine */
         if ( ( A116LocCod != 0 ) && ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttVislocacao.setGXVisible(1);
            bttBtn_enter.setGXVisible(0);
         }
         else if ( ( A116LocCod != 0 ) && ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) != 0 ) )
         {
            bttVislocacao.setGXVisible(0);
            bttBtn_enter.setGXVisible(1);
         }
         else if ( ( A116LocCod == 0 ) && ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttVislocacao.setGXVisible(0);
            bttBtn_enter.setGXVisible(1);
         }
         else if ( ( A116LocCod == 0 ) )
         {
            bttVislocacao.setGXVisible(0);
            bttBtn_enter.setGXVisible(1);
         }
      }

      protected void E13062( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A28FilCodi") )
         {
            new wconsfilme(context, base.remoteHandle, base.context).execute( out  A28FilCodi) ;
            edtFilCodigo.setValue( A28FilCodi );
            n28FilCodi = false ;
         }
         eventLevelResetContext();
      }

      protected void E12062( )
      {
         eventLevelContext();
         /* 'VisualizarLocacao' Routine */
         new tlocacao(context, base.remoteHandle, base.context).execute(  A116LocCod,  "DSP") ;
         getEqualNoModal( ) ;
      }

      /* Server side code */
      /* Aggregate/select formulas */
      /* Vertical formulas */
      public override void standaloneStartupServer( )
      {
         if ( ( AnyError == 0 ) )
         {
            standaloneNotModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
            {
               sMode9 = Gx_mode ;
               Gx_mode = "UPD" ;
               Gx_mode = sMode9 ;
            }
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               getByPrimaryKey( ) ;
               if ( ( RcdFound9 != 1 ) )
               {
                  pushError( GXResourceManager.GetMessage("noinsert") );
                  AnyError = 1 ;
                  keepFocus();
               }
            }
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               i116LocCod = A116LocCod ;
               i35MidTipo = A35MidTipo ;
               i36MidSitu = A36MidSitu ;
            }
         }
         set_caption( ) ;
         PreviousCaption = bttBtn_enter.getCaption() ;
      }

      protected void ZM069( int GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z36MidSitu = T00064_A36MidSitu[0] ;
               Z28FilCodi = T00064_A28FilCodi[0] ;
               Z35MidTipo = T00064_A35MidTipo[0] ;
               Z116LocCod = T00064_A116LocCod[0] ;
            }
            else
            {
               Z36MidSitu = A36MidSitu ;
               Z28FilCodi = A28FilCodi ;
               Z35MidTipo = A35MidTipo ;
               Z116LocCod = A116LocCod ;
            }
         }
         if ( ( GX_JID == -12 ) )
         {
            Z37MidCodi = A37MidCodi ;
            Z36MidSitu = A36MidSitu ;
            Z28FilCodi = A28FilCodi ;
            Z35MidTipo = A35MidTipo ;
            Z116LocCod = A116LocCod ;
         }
      }

      public override void standaloneNotModal( )
      {
         edtLocCodLocCodigo.setEnabled(0);
         cmbMidSituacao.setEnabled(0);
         Gx_BScreen = 0 ;
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            edtFilCodigo.setEnabled(0);
         }
         else
         {
            edtFilCodigo.setEnabled(1);
         }
      }

      public override void standaloneModal( )
      {
         A116LocCod = 0 ;
         edtLocCodLocCodigo.setValue(A116LocCod);
         n116LocCod = false ;
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((0==A35MidTipo)) && ( Gx_BScreen == 0 ) )
         {
            A35MidTipo = 1 ;
            cmbMidTipo.setValue(A35MidTipo);
            n35MidTipo = false ;
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((0==A36MidSitu)) && ( Gx_BScreen == 0 ) )
         {
            A36MidSitu = 1 ;
            cmbMidSituacao.setValue(A36MidSitu);
            n36MidSitu = false ;
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) && ( Gx_BScreen == 0 ) )
         {
            if ( ( A116LocCod != 0 ) )
            {
               cmbMidTipo.setEnabled(0);
            }
            else
            {
               if ( true )
               {
                  cmbMidTipo.setEnabled(1);
               }
               else
               {
                  if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
                  {
                     cmbMidTipo.setEnabled(0);
                  }
               }
            }
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
         }
      }

      protected void Load069( )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound9 = 1 ;
            A36MidSitu = T00066_A36MidSitu[0] ;
            n36MidSitu = T00066_n36MidSitu[0] ;
            A29FilNome = T00066_A29FilNome[0] ;
            n29FilNome = T00066_n29FilNome[0] ;
            A28FilCodi = T00066_A28FilCodi[0] ;
            n28FilCodi = T00066_n28FilCodi[0] ;
            A35MidTipo = T00066_A35MidTipo[0] ;
            n35MidTipo = T00066_n35MidTipo[0] ;
            A116LocCod = T00066_A116LocCod[0] ;
            n116LocCod = T00066_n116LocCod[0] ;
            ZM069( -12) ;
         }
         pr_default.close(4);
         OnLoadActions069( ) ;
      }

      protected void OnLoadActions069( )
      {
         if ( ( A116LocCod != 0 ) )
         {
            cmbMidTipo.setEnabled(0);
         }
         else
         {
            if ( true )
            {
               cmbMidTipo.setEnabled(1);
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  cmbMidTipo.setEnabled(0);
               }
            }
         }
      }

      protected void CheckExtendedTable069( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( ( A116LocCod != 0 ) )
         {
            cmbMidTipo.setEnabled(0);
         }
         else
         {
            if ( true )
            {
               cmbMidTipo.setEnabled(1);
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  cmbMidTipo.setEnabled(0);
               }
            }
         }
         /* Using cursor T00062 */
         pr_default.execute(0, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A28FilCodi)) ) )
            {
               pushError( "Não existe 'Cadastro de filmes.'." );
               AnyError = 1 ;
               setNextFocus( edtFilCodigo );
            }
         }
         A29FilNome = T00062_A29FilNome[0] ;
         n29FilNome = T00062_n29FilNome[0] ;
         pr_default.close(0);
         if ( true /* After */ && ((0==A28FilCodi)) )
         {
            pushError( "Código do filme deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {n116LocCod, A116LocCod});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( ((0==A116LocCod)) ) )
            {
               pushError( "Não existe 'Código de locação de mídia'." );
               AnyError = 1 ;
               setNextFocus( edtLocCodLocCodigo );
            }
         }
         pr_default.close(3);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors069( )
      {
         pr_default.close(0);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey069( )
      {
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound9 = 1 ;
         }
         else
         {
            RcdFound9 = 0 ;
         }
         pr_default.close(5);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(2) != 101) && ( T00064_A37MidCodi[0] == A37MidCodi ) )
         {
            ZM069( 12) ;
            RcdFound9 = 1 ;
            A36MidSitu = T00064_A36MidSitu[0] ;
            n36MidSitu = T00064_n36MidSitu[0] ;
            A28FilCodi = T00064_A28FilCodi[0] ;
            n28FilCodi = T00064_n28FilCodi[0] ;
            A35MidTipo = T00064_A35MidTipo[0] ;
            n35MidTipo = T00064_n35MidTipo[0] ;
            A116LocCod = T00064_A116LocCod[0] ;
            n116LocCod = T00064_n116LocCod[0] ;
            Z37MidCodi = A37MidCodi ;
            sMode9 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load069( ) ;
            Gx_mode = sMode9 ;
         }
         else
         {
            RcdFound9 = 0 ;
            InitializeNonKey069( ) ;
            sMode9 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode9 ;
         }
         K37MidCodi = A37MidCodi ;
         pr_default.close(2);
      }

      public override void getEqualNoModal( )
      {
         GetKey069( ) ;
         if ( ( RcdFound9 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound9 = 0 ;
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( T00068_A37MidCodi[0] == A37MidCodi ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( T00068_A37MidCodi[0] == A37MidCodi ) )
            {
               RcdFound9 = 1 ;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound9 = 0 ;
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( T00069_A37MidCodi[0] == A37MidCodi ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( T00069_A37MidCodi[0] == A37MidCodi ) )
            {
               RcdFound9 = 1 ;
            }
         }
         pr_default.close(7);
      }

      public override void btn_enter( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            btn_delete( ) ;
            if	(loopOnce) cleanup();
            return  ;
         }
         nKeyPressed = 1 ;
         GetKey069( ) ;
         if ( ( RcdFound9 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( edtMidCodigo );
            }
            else if ( ( A37MidCodi != Z37MidCodi ) )
            {
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtMidCodigo );
            }
            else
            {
               /* Update record */
               Update069( ) ;
               setNextFocus( edtMidCodigo );
            }
         }
         else
         {
            if ( ( A37MidCodi != Z37MidCodi ) )
            {
               /* Insert record */
               Insert069( ) ;
               setNextFocus( edtMidCodigo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( edtMidCodigo );
               }
               else
               {
                  /* Insert record */
                  Insert069( ) ;
                  setNextFocus( edtMidCodigo );
               }
            }
         }
         handleErrors();
         AfterTrn( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
         AnyError = 0 ;
         if	(loopOnce) cleanup();
      }

      public override void btn_delete( )
      {
         if ( ( A37MidCodi != Z37MidCodi ) )
         {
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtMidCodigo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( edtMidCodigo );
         }
         if ( ( AnyError != 0 ) )
         {
         }
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      protected void CheckOptimisticConcurrency069( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00063 */
            pr_default.execute(1, new Object[] {A37MidCodi});
            if ( ! (pr_default.getStatus(1) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"MIDIA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(1) == 101) || ( Z36MidSitu != T00063_A36MidSitu[0] ) || ( Z28FilCodi != T00063_A28FilCodi[0] ) || ( Z35MidTipo != T00063_A35MidTipo[0] ) || ( Z116LocCod != T00063_A116LocCod[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"MIDIA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert069( )
      {
         BeforeValidate069( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable069( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM069( 0) ;
            CheckOptimisticConcurrency069( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm069( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert069( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000610 */
                     pr_default.execute(8, new Object[] {n36MidSitu, A36MidSitu, n28FilCodi, A28FilCodi, n35MidTipo, A35MidTipo, n116LocCod, A116LocCod});
                     pr_default.close(8);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000611 */
                     pr_default.execute(9);
                     A37MidCodi = T000611_A37MidCodi[0] ;
                     pr_default.close(9);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           loopOnce = true;
                        }
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
            else
            {
               Load069( ) ;
            }
            EndLevel069( ) ;
         }
         CloseExtendedTableCursors069( ) ;
      }

      protected void Update069( )
      {
         BeforeValidate069( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable069( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency069( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm069( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate069( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000612 */
                     pr_default.execute(10, new Object[] {n36MidSitu, A36MidSitu, n28FilCodi, A28FilCodi, n35MidTipo, A35MidTipo, n116LocCod, A116LocCod, A37MidCodi});
                     pr_default.close(10);
                     DeferredUpdate069( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           loopOnce = true;
                        }
                     }
                     else
                     {
                        pushError( GXResourceManager.GetMessage("unexp") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                  }
               }
            }
            EndLevel069( ) ;
         }
         CloseExtendedTableCursors069( ) ;
      }

      protected void DeferredUpdate069( )
      {
      }

      public override void delete( )
      {
         BeforeValidate069( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency069( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls069( ) ;
            /* No cascading delete specified. */
            AfterConfirm069( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete069( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000613 */
                  pr_default.execute(11, new Object[] {A37MidCodi});
                  pr_default.close(11);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        loopOnce = true;
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
         }
         sMode9 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel069( ) ;
         Gx_mode = sMode9 ;
      }

      protected void OnDeleteControls069( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000614 */
            pr_default.execute(12, new Object[] {n28FilCodi, A28FilCodi});
            A29FilNome = T000614_A29FilNome[0] ;
            n29FilNome = T000614_n29FilNome[0] ;
            pr_default.close(12);
            if ( ( A116LocCod != 0 ) )
            {
               cmbMidTipo.setEnabled(0);
            }
            else
            {
               if ( true )
               {
                  cmbMidTipo.setEnabled(1);
               }
               else
               {
                  if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
                  {
                     cmbMidTipo.setEnabled(0);
                  }
               }
            }
         }
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000615 */
            pr_default.execute(13, new Object[] {A37MidCodi});
            if ( (pr_default.getStatus(13) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Dados da mídia locada"}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel069( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(1);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete069( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(2);
            pr_default.close(12);
            context.CommitDataStores("TMidia");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(2);
            pr_default.close(12);
            context.RollbackDataStores("TMidia");
         }
         IsModified = 0 ;
      }

      protected void ScanStart069( )
      {
         /* Using cursor T000616 */
         pr_default.execute(14, new Object[] {A37MidCodi});
         RcdFound9 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound9 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext069( )
      {
         pr_default.readNext(14);
         RcdFound9 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound9 = 1 ;
         }
      }

      protected void ScanEnd069( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm069( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert069( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate069( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete069( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete069( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate069( )
      {
         /* Before Validate Rules */
      }

      protected void CONFIRM_060( )
      {
         BeforeValidate069( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls069( ) ;
            }
            else
            {
               CheckExtendedTable069( ) ;
               CloseExtendedTableCursors069( ) ;
            }
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            PreviousCaption = bttBtn_enter.getCaption() ;
            PreviousTooltip = bttBtn_enter.getTooltip() ;
            IsConfirmed = 1 ;
         }
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
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
         pr_default.close(2);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         IsConfirmed = 0 ;
         IsModified = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         A116LocCod = 0 ;
         n116LocCod = false ;
         A35MidTipo = 0 ;
         n35MidTipo = false ;
         A36MidSitu = 0 ;
         n36MidSitu = false ;
         A28FilCodi = 0 ;
         n28FilCodi = false ;
         A29FilNome = "" ;
         n29FilNome = false ;
         i116LocCod = 0 ;
         i35MidTipo = 0 ;
         i36MidSitu = 0 ;
         lastAnyError = 0 ;
         scmdbuf = "" ;
         T00062_A29FilNome = new String[] {""} ;
         T00062_n29FilNome = new bool[] {false} ;
         sMode9 = "" ;
         RcdFound9 = 0 ;
         Z36MidSitu = 0 ;
         Z28FilCodi = 0 ;
         Z35MidTipo = 0 ;
         Z116LocCod = 0 ;
         GX_JID = 0 ;
         Z37MidCodi = 0 ;
         Gx_BScreen = 0 ;
         T00066_A37MidCodi = new int[1] ;
         T00066_A36MidSitu = new short[1] ;
         T00066_n36MidSitu = new bool[] {false} ;
         T00066_A29FilNome = new String[] {""} ;
         T00066_n29FilNome = new bool[] {false} ;
         T00066_A28FilCodi = new int[1] ;
         T00066_n28FilCodi = new bool[] {false} ;
         T00066_A35MidTipo = new short[1] ;
         T00066_n35MidTipo = new bool[] {false} ;
         T00066_A116LocCod = new int[1] ;
         T00066_n116LocCod = new bool[] {false} ;
         T00065_A116LocCod = new int[1] ;
         T00065_n116LocCod = new bool[] {false} ;
         T00067_A37MidCodi = new int[1] ;
         T00064_A37MidCodi = new int[1] ;
         T00064_A36MidSitu = new short[1] ;
         T00064_n36MidSitu = new bool[] {false} ;
         T00064_A28FilCodi = new int[1] ;
         T00064_n28FilCodi = new bool[] {false} ;
         T00064_A35MidTipo = new short[1] ;
         T00064_n35MidTipo = new bool[] {false} ;
         T00064_A116LocCod = new int[1] ;
         T00064_n116LocCod = new bool[] {false} ;
         T00068_A37MidCodi = new int[1] ;
         T00069_A37MidCodi = new int[1] ;
         T00063_A37MidCodi = new int[1] ;
         T00063_A36MidSitu = new short[1] ;
         T00063_n36MidSitu = new bool[] {false} ;
         T00063_A28FilCodi = new int[1] ;
         T00063_n28FilCodi = new bool[] {false} ;
         T00063_A35MidTipo = new short[1] ;
         T00063_n35MidTipo = new bool[] {false} ;
         T00063_A116LocCod = new int[1] ;
         T00063_n116LocCod = new bool[] {false} ;
         T000611_A37MidCodi = new int[1] ;
         T000614_A29FilNome = new String[] {""} ;
         T000614_n29FilNome = new bool[] {false} ;
         T000615_A86LocCodi = new int[1] ;
         T000615_A102LocMid = new int[1] ;
         T000616_A37MidCodi = new int[1] ;
         K37MidCodi = 0 ;
         A36MidSitu = 1 ;
         n36MidSitu = false ;
         A35MidTipo = 1 ;
         n35MidTipo = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tmidia__default(),
            new Object[][] {
                new Object[] {
               T00062_A29FilNome, T00062_n29FilNome
               }
               , new Object[] {
               T00063_A37MidCodi, T00063_A36MidSitu, T00063_n36MidSitu, T00063_A28FilCodi, T00063_n28FilCodi, T00063_A35MidTipo, T00063_n35MidTipo, T00063_A116LocCod, T00063_n116LocCod
               }
               , new Object[] {
               T00064_A37MidCodi, T00064_A36MidSitu, T00064_n36MidSitu, T00064_A28FilCodi, T00064_n28FilCodi, T00064_A35MidTipo, T00064_n35MidTipo, T00064_A116LocCod, T00064_n116LocCod
               }
               , new Object[] {
               T00065_A116LocCod
               }
               , new Object[] {
               T00066_A37MidCodi, T00066_A36MidSitu, T00066_n36MidSitu, T00066_A29FilNome, T00066_n29FilNome, T00066_A28FilCodi, T00066_n28FilCodi, T00066_A35MidTipo, T00066_n35MidTipo, T00066_A116LocCod,
               T00066_n116LocCod
               }
               , new Object[] {
               T00067_A37MidCodi
               }
               , new Object[] {
               T00068_A37MidCodi
               }
               , new Object[] {
               T00069_A37MidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000611_A37MidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000614_A29FilNome, T000614_n29FilNome
               }
               , new Object[] {
               T000615_A86LocCodi, T000615_A102LocMid
               }
               , new Object[] {
               T000616_A37MidCodi
               }
            }
         );
         reloadDynamicLists(0);
         K37MidCodi = 0 ;
         edtMidCodigo.setValue(A37MidCodi);
         A36MidSitu = 1 ;
         cmbMidSituacao.setValue(A36MidSitu);
         n36MidSitu = false ;
         A35MidTipo = 1 ;
         cmbMidTipo.setValue(A35MidTipo);
         n35MidTipo = false ;
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short A35MidTipo ;
      protected short A36MidSitu ;
      protected short geteqAfterKey= 1 ;
      protected short i35MidTipo ;
      protected short i36MidSitu ;
      protected short RcdFound9 ;
      protected short Z36MidSitu ;
      protected short Z35MidTipo ;
      protected short Gx_BScreen ;
      protected int trnEnded ;
      protected int A116LocCod ;
      protected int A28FilCodi ;
      protected int K37MidCodi ;
      protected int A37MidCodi ;
      protected int i116LocCod ;
      protected int lastAnyError ;
      protected int Z28FilCodi ;
      protected int Z116LocCod ;
      protected int GX_JID ;
      protected int Z37MidCodi ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String scmdbuf ;
      protected String sMode9 ;
      protected bool n116LocCod ;
      protected bool n35MidTipo ;
      protected bool n36MidSitu ;
      protected bool n28FilCodi ;
      protected bool n29FilNome ;
      protected String A29FilNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtMidCodigo ;
      protected GUIObjectShort cmbMidTipo ;
      protected GUIObjectShort cmbMidSituacao ;
      protected GUIObjectInt edtFilCodigo ;
      protected GUIObjectString edtFilNome ;
      protected GUIObjectInt edtLocCodLocCodigo ;
      protected IGXButton bttVislocacao ;
      protected IGXButton bttBtn_enter ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl8 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl12 ;
      protected ILabel lbllbl13 ;
      protected IGXRectangle rctrct16 ;
      protected IDataReader T00062 ;
      protected IDataStoreProvider pr_default ;
      protected String[] T00062_A29FilNome ;
      protected bool[] T00062_n29FilNome ;
      protected IDataReader T00063 ;
      protected IDataReader T00064 ;
      protected IDataReader T00065 ;
      protected IDataReader T00066 ;
      protected int[] T00066_A37MidCodi ;
      protected short[] T00066_A36MidSitu ;
      protected bool[] T00066_n36MidSitu ;
      protected String[] T00066_A29FilNome ;
      protected bool[] T00066_n29FilNome ;
      protected int[] T00066_A28FilCodi ;
      protected bool[] T00066_n28FilCodi ;
      protected short[] T00066_A35MidTipo ;
      protected bool[] T00066_n35MidTipo ;
      protected int[] T00066_A116LocCod ;
      protected bool[] T00066_n116LocCod ;
      protected int[] T00065_A116LocCod ;
      protected bool[] T00065_n116LocCod ;
      protected IDataReader T00067 ;
      protected int[] T00067_A37MidCodi ;
      protected int[] T00064_A37MidCodi ;
      protected short[] T00064_A36MidSitu ;
      protected bool[] T00064_n36MidSitu ;
      protected int[] T00064_A28FilCodi ;
      protected bool[] T00064_n28FilCodi ;
      protected short[] T00064_A35MidTipo ;
      protected bool[] T00064_n35MidTipo ;
      protected int[] T00064_A116LocCod ;
      protected bool[] T00064_n116LocCod ;
      protected IDataReader T00068 ;
      protected int[] T00068_A37MidCodi ;
      protected IDataReader T00069 ;
      protected int[] T00069_A37MidCodi ;
      protected int[] T00063_A37MidCodi ;
      protected short[] T00063_A36MidSitu ;
      protected bool[] T00063_n36MidSitu ;
      protected int[] T00063_A28FilCodi ;
      protected bool[] T00063_n28FilCodi ;
      protected short[] T00063_A35MidTipo ;
      protected bool[] T00063_n35MidTipo ;
      protected int[] T00063_A116LocCod ;
      protected bool[] T00063_n116LocCod ;
      protected IDataReader T000611 ;
      protected int[] T000611_A37MidCodi ;
      protected IDataReader T000614 ;
      protected String[] T000614_A29FilNome ;
      protected bool[] T000614_n29FilNome ;
      protected IDataReader T000615 ;
      protected int[] T000615_A86LocCodi ;
      protected int[] T000615_A102LocMid ;
      protected IDataReader T000616 ;
      protected int[] T000616_A37MidCodi ;
   }

   public class tmidia__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[2])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[3])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[4])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[5])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[6])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[7])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[13])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@LocCodLocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@MidSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocCodLocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@MidSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocCodLocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000616 ;
          prmT000616 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00062", "SELECT [FilNome] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00063", "SELECT [MidCodigo], [MidSituacao], [FilCodigo], [MidTipo], [LocCodLocCodigo] AS LocCodLocCodigo FROM [MIDIA] WITH (UPDLOCK) WHERE [MidCodigo] = @MidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00064", "SELECT [MidCodigo], [MidSituacao], [FilCodigo], [MidTipo], [LocCodLocCodigo] AS LocCodLocCodigo FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @MidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00065", "SELECT [LocCodigo] AS LocCodLocCodigo FROM [LOCACAO] WITH (NOLOCK) WHERE [LocCodigo] = @LocCodLocCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00066", "SELECT TM1.[MidCodigo], TM1.[MidSituacao], T2.[FilNome], TM1.[FilCodigo], TM1.[MidTipo], TM1.[LocCodLocCodigo] AS LocCodLocCodigo FROM ([MIDIA] TM1 WITH (NOLOCK) LEFT JOIN [FILME] T2 WITH (NOLOCK) ON T2.[FilCodigo] = TM1.[FilCodigo]) WHERE TM1.[MidCodigo] = @MidCodigo ORDER BY TM1.[MidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00067", "SELECT [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @MidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00068", "SELECT TOP 1 [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @MidCodigo ORDER BY [MidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00069", "SELECT TOP 1 [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @MidCodigo ORDER BY [MidCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000610", "INSERT INTO [MIDIA] ([MidSituacao], [FilCodigo], [MidTipo], [LocCodLocCodigo]) VALUES (@MidSituacao, @FilCodigo, @MidTipo, @LocCodLocCodigo)", GxErrorMask.GX_NOMASK,prmT000610)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000611", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000612", "UPDATE [MIDIA] SET [MidSituacao]=@MidSituacao, [FilCodigo]=@FilCodigo, [MidTipo]=@MidTipo, [LocCodLocCodigo]=@LocCodLocCodigo  WHERE [MidCodigo] = @MidCodigo", GxErrorMask.GX_NOMASK,prmT000612)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000613", "DELETE FROM [MIDIA]  WHERE [MidCodigo] = @MidCodigo", GxErrorMask.GX_NOMASK,prmT000613)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000614", "SELECT [FilNome] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000615", "SELECT TOP 1 [LocCodigo], [LocMidMidCodigo] FROM [LOCACAOLOCACAOMIDIA] WITH (NOLOCK) WHERE [LocMidMidCodigo] = @MidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000616", "SELECT [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @MidCodigo ORDER BY [MidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000616,100,0,true,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[7]);
                }
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[7]);
                }
                stmt.SetParameter(5, (int)parms[8]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
