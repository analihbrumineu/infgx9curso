/*
               File: Cidade
        Description: Cadastro de cidades.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:17.45
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
   public class tcidade : GXTransaction
   {
      public tcidade( int hnd ,
                      ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tcidade( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tcidade( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey058( )
      {
         A27CidNome = "" ;
         n27CidNome = false ;
         n27CidNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A27CidNome).TrimEnd(' ') )==0)) ? true : false) ;
         A24EstCodi = 0 ;
         n24EstCodi = false ;
         n24EstCodi = (((0==A24EstCodi)) ? true : false) ;
         A25EstUF = "" ;
         n25EstUF = false ;
         A12EstNome = "" ;
         n12EstNome = false ;
      }

      protected void InitAll058( )
      {
         K26CidCodi = A26CidCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey058( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void ResetCaption050( )
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
         return "Cidade" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de cidades" ;
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
         return 741 ;
      }

      public override int getFrmHeight( )
      {
         return 247 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TCidade.htm";
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

      public void execute( int aP0_CidCodigo ,
                           String aP1_Gx_mode )
      {
         this.A26CidCodi = aP0_CidCodigo;
         this.Gx_mode = aP1_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 741 , 247 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtCidCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),192, 64, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 192 , 64 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A26CidCodi" );
         ((GXEdit) edtCidCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtCidCodigo.addFocusListener(this);
         edtCidCodigo.getGXComponent().setHelpId("HLP_TCidade.htm");
         edtCidNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),355, 64, 256, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 355 , 64 , 256 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A27CidNome" );
         ((GXEdit) edtCidNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtCidNome.addFocusListener(this);
         edtCidNome.getGXComponent().setHelpId("HLP_TCidade.htm");
         edtEstCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),192, 91, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 192 , 91 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A24EstCodi" );
         ((GXEdit) edtEstCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtEstCodigo.addFocusListener(this);
         edtEstCodigo.getGXComponent().setHelpId("HLP_TCidade.htm");
         edtEstUF = new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),192, 116, 24, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.CHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 192 , 116 , 24 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A25EstUF" );
         ((GXEdit) edtEstUF.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstUF.addFocusListener(this);
         edtEstUF.getGXComponent().setHelpId("HLP_TCidade.htm");
         edtEstNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),355, 116, 256, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 355 , 116 , 256 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A12EstNome" );
         ((GXEdit) edtEstNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstNome.addFocusListener(this);
         edtEstNome.getGXComponent().setHelpId("HLP_TCidade.htm");
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Enter" ,  585 ,  169 ,  89 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Enter");
         bttBtn_enter.addActionListener(this);
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 67 , 68 , 40 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 301 , 68 , 40 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Código do Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 67 , 95 , 101 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 67 , 120 , 17 , 13 );
         lbllbl12 = UIFactory.getLabel(GXPanel1, "Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 301 , 120 , 40 , 13 );
         edtEstCodigo.addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         focusManager.setControlList(new IFocusableControl[] {
                   edtCidCodigo ,
                   edtCidNome ,
                   edtEstCodigo ,
                   edtEstUF ,
                   edtEstNome ,
                   bttBtn_enter
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Cidcodigo();
         setFocus(edtCidNome, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey058( ) ;
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setGXEnabled(0);
            edtCidCodigo.setEnabled(0);
            edtCidNome.setEnabled(0);
            edtEstCodigo.setEnabled(0);
            edtEstUF.setEnabled(0);
            edtEstNome.setEnabled(0);
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
                  InitAll058( ) ;
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
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtCidCodigo.getGXCursor() );
            return;
         }
         if ( edtCidNome.isEventSource(eventSource) ) {
            setGXCursor( edtCidNome.getGXCursor() );
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtEstCodigo.getGXCursor() );
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            setGXCursor( edtEstUF.getGXCursor() );
            return;
         }
         if ( edtEstNome.isEventSource(eventSource) ) {
            setGXCursor( edtEstNome.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            Valid_Estcodigo ();
            return;
         }
         if ( edtCidNome.isEventSource(eventSource) ) {
            Valid_Cidnome ();
            return;
         }
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            Valid_Cidcodigo ();
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            A26CidCodi = edtCidCodigo.getValue() ;
            return;
         }
         if ( edtCidNome.isEventSource(eventSource) ) {
            A27CidNome = edtCidNome.getValue() ;
            n27CidNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A27CidNome).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            A24EstCodi = edtEstCodigo.getValue() ;
            n24EstCodi = (((0==A24EstCodi)) ? true : false) ;
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            A25EstUF = edtEstUF.getValue() ;
            return;
         }
         if ( edtEstNome.isEventSource(eventSource) ) {
            A12EstNome = edtEstNome.getValue() ;
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
            /* Execute user event: E11052 */
            E11052 ();
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
         if ( ( edtCidCodigo.isEventSource(eventSource) ) && ( ( A26CidCodi != edtCidCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
         if ( ( edtCidNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A27CidNome.TrimEnd(' '), edtCidNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtEstCodigo.isEventSource(eventSource) ) && ( ( A24EstCodi != edtEstCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtEstUF.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A25EstUF.TrimEnd(' '), edtEstUF.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtEstNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A12EstNome.TrimEnd(' '), edtEstNome.getValue().TrimEnd(' ') ) != 0 ) ) )
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
         ResetCaption050( ) ;
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
         if (( edtEstCodigo.isEventSource(eventSource) ) && ( edtEstCodigo.isEnabled() )) {
            prompt_24_8( ) ;
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
         if ( edtCidNome.isEventSource(eventSource) )
         {
            edtCidNome.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtEstCodigo.isEventSource(eventSource) )
         {
            edtEstCodigo.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      public override void VariablesToControls( )
      {
         edtCidCodigo.setValue( A26CidCodi );
         edtCidNome.setValue( A27CidNome );
         edtEstCodigo.setValue( A24EstCodi );
         edtEstUF.setValue( A25EstUF );
         edtEstNome.setValue( A12EstNome );
      }

      public override void ControlsToVariables( )
      {
         A26CidCodi = (int)(edtCidCodigo.getValue()) ;
         edtCidCodigo.setValue(A26CidCodi);
         n26CidCodi = false ;
         A27CidNome = (String)(edtCidNome.getValue()) ;
         edtCidNome.setValue(A27CidNome);
         n27CidNome = false ;
         n27CidNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A27CidNome).TrimEnd(' ') )==0)) ? true : false) ;
         A24EstCodi = (int)(edtEstCodigo.getValue()) ;
         edtEstCodigo.setValue(A24EstCodi);
         n24EstCodi = false ;
         n24EstCodi = (((0==A24EstCodi)) ? true : false) ;
         A25EstUF = (String)(edtEstUF.getValue()) ;
         edtEstUF.setValue(A25EstUF);
         n25EstUF = false ;
         A12EstNome = (String)(edtEstNome.getValue()) ;
         edtEstNome.setValue(A12EstNome);
         n12EstNome = false ;
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

      protected void prompt_24_8( )
      {
         new wgx0070(context, base.remoteHandle, base.context).execute( out  A24EstCodi) ;
         edtEstCodigo.setValue( A24EstCodi );
         n24EstCodi = false ;
         setFocus(edtEstCodigo);
         ResetCaption050( ) ;
      }

      protected void Valid_Cidcodigo( )
      {
         if ( ( A26CidCodi != K26CidCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K26CidCodi = A26CidCodi ;
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

      protected void Valid_Cidnome( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A27CidNome).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Nome da cidade deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtCidNome );
            setFocusNext();
         }
      }

      protected void Valid_Estcodigo( )
      {
         /* Using cursor T00052 */
         pr_default.execute(0, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A24EstCodi)) ) )
            {
               GXutil.msg( me(), "Não existe 'Cadastro de Estados.'." );
               AnyError = 1 ;
               setNextFocus( edtEstCodigo );
               setFocusNext();
            }
         }
         A25EstUF = T00052_A25EstUF[0] ;
         n25EstUF = T00052_n25EstUF[0] ;
         A12EstNome = T00052_A12EstNome[0] ;
         n12EstNome = T00052_n12EstNome[0] ;
         pr_default.close(0);
         edtEstUF.setValue( A25EstUF );
         edtEstNome.setValue( A12EstNome );
         if ( true /* After */ && ((0==A24EstCodi)) )
         {
            GXutil.msg( me(), "Código de Estado deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtEstCodigo );
            setFocusNext();
         }
         pr_default.close(0);
      }

      protected void E11052( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A24EstCodi") )
         {
            new wconsestado(context, base.remoteHandle, base.context).execute( out  A24EstCodi) ;
            edtEstCodigo.setValue( A24EstCodi );
            n24EstCodi = false ;
         }
         eventLevelResetContext();
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
               sMode8 = Gx_mode ;
               Gx_mode = "UPD" ;
               Gx_mode = sMode8 ;
            }
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               getByPrimaryKey( ) ;
               if ( ( RcdFound8 != 1 ) )
               {
                  pushError( GXResourceManager.GetMessage("noinsert") );
                  AnyError = 1 ;
                  keepFocus();
               }
            }
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
            }
         }
         set_caption( ) ;
         PreviousCaption = bttBtn_enter.getCaption() ;
      }

      protected void ZM058( int GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z27CidNome = T00054_A27CidNome[0] ;
               Z24EstCodi = T00054_A24EstCodi[0] ;
            }
            else
            {
               Z27CidNome = A27CidNome ;
               Z24EstCodi = A24EstCodi ;
            }
         }
         if ( ( GX_JID == -3 ) )
         {
            Z26CidCodi = A26CidCodi ;
            Z27CidNome = A27CidNome ;
            Z24EstCodi = A24EstCodi ;
         }
      }

      public override void standaloneNotModal( )
      {
      }

      public override void standaloneModal( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
         }
      }

      protected void Load058( )
      {
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound8 = 1 ;
            A27CidNome = T00055_A27CidNome[0] ;
            n27CidNome = T00055_n27CidNome[0] ;
            A25EstUF = T00055_A25EstUF[0] ;
            n25EstUF = T00055_n25EstUF[0] ;
            A12EstNome = T00055_A12EstNome[0] ;
            n12EstNome = T00055_n12EstNome[0] ;
            A24EstCodi = T00055_A24EstCodi[0] ;
            n24EstCodi = T00055_n24EstCodi[0] ;
            ZM058( -3) ;
         }
         pr_default.close(3);
         OnLoadActions058( ) ;
      }

      protected void OnLoadActions058( )
      {
      }

      protected void CheckExtendedTable058( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A27CidNome).TrimEnd(' ') )==0)) )
         {
            pushError( "Nome da cidade deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         /* Using cursor T00052 */
         pr_default.execute(0, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A24EstCodi)) ) )
            {
               pushError( "Não existe 'Cadastro de Estados.'." );
               AnyError = 1 ;
               setNextFocus( edtEstCodigo );
            }
         }
         A25EstUF = T00052_A25EstUF[0] ;
         n25EstUF = T00052_n25EstUF[0] ;
         A12EstNome = T00052_A12EstNome[0] ;
         n12EstNome = T00052_n12EstNome[0] ;
         pr_default.close(0);
         if ( true /* After */ && ((0==A24EstCodi)) )
         {
            pushError( "Código de Estado deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors058( )
      {
         pr_default.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey058( )
      {
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound8 = 1 ;
         }
         else
         {
            RcdFound8 = 0 ;
         }
         pr_default.close(4);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(2) != 101) && ( T00054_A26CidCodi[0] == A26CidCodi ) )
         {
            ZM058( 3) ;
            RcdFound8 = 1 ;
            A27CidNome = T00054_A27CidNome[0] ;
            n27CidNome = T00054_n27CidNome[0] ;
            A24EstCodi = T00054_A24EstCodi[0] ;
            n24EstCodi = T00054_n24EstCodi[0] ;
            Z26CidCodi = A26CidCodi ;
            sMode8 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load058( ) ;
            Gx_mode = sMode8 ;
         }
         else
         {
            RcdFound8 = 0 ;
            InitializeNonKey058( ) ;
            sMode8 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode8 ;
         }
         K26CidCodi = A26CidCodi ;
         pr_default.close(2);
      }

      public override void getEqualNoModal( )
      {
         GetKey058( ) ;
         if ( ( RcdFound8 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound8 = 0 ;
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( T00057_A26CidCodi[0] == A26CidCodi ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( T00057_A26CidCodi[0] == A26CidCodi ) )
            {
               RcdFound8 = 1 ;
            }
         }
         pr_default.close(5);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0 ;
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( T00058_A26CidCodi[0] == A26CidCodi ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( T00058_A26CidCodi[0] == A26CidCodi ) )
            {
               RcdFound8 = 1 ;
            }
         }
         pr_default.close(6);
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
         GetKey058( ) ;
         if ( ( RcdFound8 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( edtCidCodigo );
            }
            else if ( ( A26CidCodi != Z26CidCodi ) )
            {
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtCidCodigo );
            }
            else
            {
               /* Update record */
               Update058( ) ;
               setNextFocus( edtCidCodigo );
            }
         }
         else
         {
            if ( ( A26CidCodi != Z26CidCodi ) )
            {
               /* Insert record */
               Insert058( ) ;
               setNextFocus( edtCidCodigo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( edtCidCodigo );
               }
               else
               {
                  /* Insert record */
                  Insert058( ) ;
                  setNextFocus( edtCidCodigo );
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
         if ( ( A26CidCodi != Z26CidCodi ) )
         {
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtCidCodigo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( edtCidCodigo );
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

      protected void CheckOptimisticConcurrency058( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00053 */
            pr_default.execute(1, new Object[] {n26CidCodi, A26CidCodi});
            if ( ! (pr_default.getStatus(1) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"CIDADE"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(1) == 101) || ( String.CompareOrdinal(Z27CidNome.TrimEnd(' '), T00053_A27CidNome[0].TrimEnd(' ') ) != 0 ) || ( Z24EstCodi != T00053_A24EstCodi[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"CIDADE"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert058( )
      {
         BeforeValidate058( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable058( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM058( 0) ;
            CheckOptimisticConcurrency058( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm058( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert058( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T00059 */
                     pr_default.execute(7, new Object[] {n27CidNome, A27CidNome, n24EstCodi, A24EstCodi});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000510 */
                     pr_default.execute(8);
                     A26CidCodi = T000510_A26CidCodi[0] ;
                     n26CidCodi = T000510_n26CidCodi[0] ;
                     pr_default.close(8);
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
               Load058( ) ;
            }
            EndLevel058( ) ;
         }
         CloseExtendedTableCursors058( ) ;
      }

      protected void Update058( )
      {
         BeforeValidate058( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable058( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency058( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm058( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate058( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000511 */
                     pr_default.execute(9, new Object[] {n27CidNome, A27CidNome, n24EstCodi, A24EstCodi, n26CidCodi, A26CidCodi});
                     pr_default.close(9);
                     DeferredUpdate058( ) ;
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
            EndLevel058( ) ;
         }
         CloseExtendedTableCursors058( ) ;
      }

      protected void DeferredUpdate058( )
      {
      }

      public override void delete( )
      {
         BeforeValidate058( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency058( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls058( ) ;
            /* No cascading delete specified. */
            AfterConfirm058( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete058( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000512 */
                  pr_default.execute(10, new Object[] {n26CidCodi, A26CidCodi});
                  pr_default.close(10);
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
         sMode8 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel058( ) ;
         Gx_mode = sMode8 ;
      }

      protected void OnDeleteControls058( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000513 */
            pr_default.execute(11, new Object[] {n24EstCodi, A24EstCodi});
            A25EstUF = T000513_A25EstUF[0] ;
            n25EstUF = T000513_n25EstUF[0] ;
            A12EstNome = T000513_A12EstNome[0] ;
            n12EstNome = T000513_n12EstNome[0] ;
            pr_default.close(11);
         }
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000514 */
            pr_default.execute(12, new Object[] {n26CidCodi, A26CidCodi});
            if ( (pr_default.getStatus(12) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de pessoas."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel058( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(1);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete058( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(2);
            pr_default.close(11);
            context.CommitDataStores("TCidade");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(2);
            pr_default.close(11);
            context.RollbackDataStores("TCidade");
         }
         IsModified = 0 ;
      }

      protected void ScanStart058( )
      {
         /* Using cursor T000515 */
         pr_default.execute(13, new Object[] {n26CidCodi, A26CidCodi});
         RcdFound8 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound8 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext058( )
      {
         pr_default.readNext(13);
         RcdFound8 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound8 = 1 ;
         }
      }

      protected void ScanEnd058( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm058( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert058( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate058( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete058( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete058( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate058( )
      {
         /* Before Validate Rules */
      }

      protected void CONFIRM_050( )
      {
         BeforeValidate058( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls058( ) ;
            }
            else
            {
               CheckExtendedTable058( ) ;
               CloseExtendedTableCursors058( ) ;
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
         pr_default.close(11);
      }

      public override void initialize( )
      {
         IsConfirmed = 0 ;
         IsModified = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         A27CidNome = "" ;
         n27CidNome = false ;
         A24EstCodi = 0 ;
         n24EstCodi = false ;
         A25EstUF = "" ;
         n25EstUF = false ;
         A12EstNome = "" ;
         n12EstNome = false ;
         lastAnyError = 0 ;
         n26CidCodi = false ;
         scmdbuf = "" ;
         T00052_A25EstUF = new String[] {""} ;
         T00052_n25EstUF = new bool[] {false} ;
         T00052_A12EstNome = new String[] {""} ;
         T00052_n12EstNome = new bool[] {false} ;
         sMode8 = "" ;
         RcdFound8 = 0 ;
         Z27CidNome = "" ;
         Z24EstCodi = 0 ;
         GX_JID = 0 ;
         Z26CidCodi = 0 ;
         T00055_A26CidCodi = new int[1] ;
         T00055_n26CidCodi = new bool[] {false} ;
         T00055_A27CidNome = new String[] {""} ;
         T00055_n27CidNome = new bool[] {false} ;
         T00055_A25EstUF = new String[] {""} ;
         T00055_n25EstUF = new bool[] {false} ;
         T00055_A12EstNome = new String[] {""} ;
         T00055_n12EstNome = new bool[] {false} ;
         T00055_A24EstCodi = new int[1] ;
         T00055_n24EstCodi = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00056_A26CidCodi = new int[1] ;
         T00056_n26CidCodi = new bool[] {false} ;
         T00054_A26CidCodi = new int[1] ;
         T00054_n26CidCodi = new bool[] {false} ;
         T00054_A27CidNome = new String[] {""} ;
         T00054_n27CidNome = new bool[] {false} ;
         T00054_A24EstCodi = new int[1] ;
         T00054_n24EstCodi = new bool[] {false} ;
         T00057_A26CidCodi = new int[1] ;
         T00057_n26CidCodi = new bool[] {false} ;
         T00058_A26CidCodi = new int[1] ;
         T00058_n26CidCodi = new bool[] {false} ;
         T00053_A26CidCodi = new int[1] ;
         T00053_n26CidCodi = new bool[] {false} ;
         T00053_A27CidNome = new String[] {""} ;
         T00053_n27CidNome = new bool[] {false} ;
         T00053_A24EstCodi = new int[1] ;
         T00053_n24EstCodi = new bool[] {false} ;
         T000510_A26CidCodi = new int[1] ;
         T000510_n26CidCodi = new bool[] {false} ;
         T000513_A25EstUF = new String[] {""} ;
         T000513_n25EstUF = new bool[] {false} ;
         T000513_A12EstNome = new String[] {""} ;
         T000513_n12EstNome = new bool[] {false} ;
         T000514_A13PesCodi = new int[1] ;
         T000515_A26CidCodi = new int[1] ;
         T000515_n26CidCodi = new bool[] {false} ;
         K26CidCodi = 0 ;
         n26CidCodi = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tcidade__default(),
            new Object[][] {
                new Object[] {
               T00052_A25EstUF, T00052_n25EstUF, T00052_A12EstNome, T00052_n12EstNome
               }
               , new Object[] {
               T00053_A26CidCodi, T00053_A27CidNome, T00053_n27CidNome, T00053_A24EstCodi, T00053_n24EstCodi
               }
               , new Object[] {
               T00054_A26CidCodi, T00054_A27CidNome, T00054_n27CidNome, T00054_A24EstCodi, T00054_n24EstCodi
               }
               , new Object[] {
               T00055_A26CidCodi, T00055_A27CidNome, T00055_n27CidNome, T00055_A25EstUF, T00055_n25EstUF, T00055_A12EstNome, T00055_n12EstNome, T00055_A24EstCodi, T00055_n24EstCodi
               }
               , new Object[] {
               T00056_A26CidCodi
               }
               , new Object[] {
               T00057_A26CidCodi
               }
               , new Object[] {
               T00058_A26CidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000510_A26CidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000513_A25EstUF, T000513_n25EstUF, T000513_A12EstNome, T000513_n12EstNome
               }
               , new Object[] {
               T000514_A13PesCodi
               }
               , new Object[] {
               T000515_A26CidCodi
               }
            }
         );
         reloadDynamicLists(0);
         K26CidCodi = 0 ;
         edtCidCodigo.setValue(A26CidCodi);
         n26CidCodi = false ;
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short geteqAfterKey= 1 ;
      protected short RcdFound8 ;
      protected short Gx_BScreen ;
      protected int trnEnded ;
      protected int A24EstCodi ;
      protected int K26CidCodi ;
      protected int A26CidCodi ;
      protected int lastAnyError ;
      protected int Z24EstCodi ;
      protected int GX_JID ;
      protected int Z26CidCodi ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String A25EstUF ;
      protected String scmdbuf ;
      protected String sMode8 ;
      protected bool n27CidNome ;
      protected bool n24EstCodi ;
      protected bool n25EstUF ;
      protected bool n12EstNome ;
      protected bool n26CidCodi ;
      protected String A27CidNome ;
      protected String A12EstNome ;
      protected String Z27CidNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtCidCodigo ;
      protected GUIObjectString edtCidNome ;
      protected GUIObjectInt edtEstCodigo ;
      protected GUIObjectString edtEstUF ;
      protected GUIObjectString edtEstNome ;
      protected IGXButton bttBtn_enter ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl8 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl12 ;
      protected IDataReader T00052 ;
      protected IDataStoreProvider pr_default ;
      protected String[] T00052_A25EstUF ;
      protected bool[] T00052_n25EstUF ;
      protected String[] T00052_A12EstNome ;
      protected bool[] T00052_n12EstNome ;
      protected IDataReader T00053 ;
      protected IDataReader T00054 ;
      protected IDataReader T00055 ;
      protected int[] T00055_A26CidCodi ;
      protected bool[] T00055_n26CidCodi ;
      protected String[] T00055_A27CidNome ;
      protected bool[] T00055_n27CidNome ;
      protected String[] T00055_A25EstUF ;
      protected bool[] T00055_n25EstUF ;
      protected String[] T00055_A12EstNome ;
      protected bool[] T00055_n12EstNome ;
      protected int[] T00055_A24EstCodi ;
      protected bool[] T00055_n24EstCodi ;
      protected IDataReader T00056 ;
      protected int[] T00056_A26CidCodi ;
      protected bool[] T00056_n26CidCodi ;
      protected int[] T00054_A26CidCodi ;
      protected bool[] T00054_n26CidCodi ;
      protected String[] T00054_A27CidNome ;
      protected bool[] T00054_n27CidNome ;
      protected int[] T00054_A24EstCodi ;
      protected bool[] T00054_n24EstCodi ;
      protected IDataReader T00057 ;
      protected int[] T00057_A26CidCodi ;
      protected bool[] T00057_n26CidCodi ;
      protected IDataReader T00058 ;
      protected int[] T00058_A26CidCodi ;
      protected bool[] T00058_n26CidCodi ;
      protected int[] T00053_A26CidCodi ;
      protected bool[] T00053_n26CidCodi ;
      protected String[] T00053_A27CidNome ;
      protected bool[] T00053_n27CidNome ;
      protected int[] T00053_A24EstCodi ;
      protected bool[] T00053_n24EstCodi ;
      protected IDataReader T000510 ;
      protected int[] T000510_A26CidCodi ;
      protected bool[] T000510_n26CidCodi ;
      protected IDataReader T000513 ;
      protected String[] T000513_A25EstUF ;
      protected bool[] T000513_n25EstUF ;
      protected String[] T000513_A12EstNome ;
      protected bool[] T000513_n12EstNome ;
      protected IDataReader T000514 ;
      protected int[] T000514_A13PesCodi ;
      protected IDataReader T000515 ;
      protected int[] T000515_A26CidCodi ;
      protected bool[] T000515_n26CidCodi ;
   }

   public class tcidade__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[7])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@CidNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@CidNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000515 ;
          prmT000515 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00052", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00053", "SELECT [CidCodigo], [CidNome], [EstCodigo] FROM [CIDADE] WITH (UPDLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00054", "SELECT [CidCodigo], [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00055", "SELECT TM1.[CidCodigo], TM1.[CidNome], T2.[EstUF], T2.[EstNome], TM1.[EstCodigo] FROM ([CIDADE] TM1 WITH (NOLOCK) LEFT JOIN [ESTADO] T2 WITH (NOLOCK) ON T2.[EstCodigo] = TM1.[EstCodigo]) WHERE TM1.[CidCodigo] = @CidCodigo ORDER BY TM1.[CidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00056", "SELECT [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00057", "SELECT TOP 1 [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ORDER BY [CidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00058", "SELECT TOP 1 [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ORDER BY [CidCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00059", "INSERT INTO [CIDADE] ([CidNome], [EstCodigo]) VALUES (@CidNome, @EstCodigo)", GxErrorMask.GX_NOMASK,prmT00059)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000510", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000510,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000511", "UPDATE [CIDADE] SET [CidNome]=@CidNome, [EstCodigo]=@EstCodigo  WHERE [CidCodigo] = @CidCodigo", GxErrorMask.GX_NOMASK,prmT000511)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000512", "DELETE FROM [CIDADE]  WHERE [CidCodigo] = @CidCodigo", GxErrorMask.GX_NOMASK,prmT000512)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000513", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000513,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000514", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000515", "SELECT [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ORDER BY [CidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,100,0,true,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 2) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 13 :
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
                }
                break;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
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
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[5]);
                }
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
       }
    }

 }

}
