/*
               File: Astro
        Description: Cadastro de astros.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 8:48:34.82
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
   public class tastro : GXTransaction
   {
      public tastro( int hnd ,
                     ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tastro( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tastro( IGxContext context ,
                     int hnd ,
                     ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey0810( )
      {
         A50AstNome = "" ;
         n50AstNome = false ;
         n50AstNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A50AstNome).TrimEnd(' ') )==0)) ? true : false) ;
         A113AstDat = (DateTime)(DateTime.MinValue) ;
         n113AstDat = false ;
         n113AstDat = (((DateTime.MinValue==A113AstDat)) ? true : false) ;
         A114AstDat = (DateTime)(DateTime.MinValue) ;
         n114AstDat = false ;
         n114AstDat = (((DateTime.MinValue==A114AstDat)) ? true : false) ;
         A53AstDesc = "" ;
         n53AstDesc = false ;
         n53AstDesc = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A53AstDesc).TrimEnd(' ') )==0)) ? true : false) ;
      }

      protected void InitAll0810( )
      {
         K49AstCodi = A49AstCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey0810( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void ResetCaption080( )
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
         return "Astro" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de astros." ;
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
         return 560 ;
      }

      public override int getFrmHeight( )
      {
         return 338 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TAstro.htm";
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

      public void execute( int aP0_AstCodigo ,
                           String aP1_Gx_mode )
      {
         this.A49AstCodi = aP0_AstCodigo;
         this.Gx_mode = aP1_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 560 , 338 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         bttbtt2 = UIFactory.getGXButton( GXPanel1 , "Enter" ,  442 ,  299 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt2.setTooltip("Enter");
         bttbtt2.addActionListener(this);
         tctrltctrl3 = new GXTabControl (this,  GXPanel1 , 0 , 0 , 560 , 287 , UIFactory.getColor(5) , UIFactory.getColor(8) , 0, 0, 0, false );
         tpagetpage4 = new GXTabPage ( tctrltctrl3 , "Personalidade" , 5 , 29 , 555 , 258 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         edtAstCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),169, 78, 78, 21, tpagetpage4.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , tpagetpage4.getGXPanel() , 169 , 78 , 78 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A49AstCodi" );
         ((GXEdit) edtAstCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtAstCodigo.addFocusListener(this);
         edtAstCodigo.getGXComponent().setHelpId("HLP_TAstro.htm");
         edtAstNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),169, 104, 312, 21, tpagetpage4.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage4.getGXPanel() , 169 , 104 , 312 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A50AstNome" );
         ((GXEdit) edtAstNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtAstNome.addFocusListener(this);
         edtAstNome.getGXComponent().setHelpId("HLP_TAstro.htm");
         edtAstDatNascimento = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),169, 156, 80, 21, tpagetpage4.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , tpagetpage4.getGXPanel() , 169 , 156 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A113AstDat" );
         ((GXEdit) edtAstDatNascimento.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtAstDatNascimento.addFocusListener(this);
         edtAstDatNascimento.getGXComponent().setHelpId("HLP_TAstro.htm");
         edtAstDatFalecimento = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),169, 182, 80, 21, tpagetpage4.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , tpagetpage4.getGXPanel() , 169 , 182 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A114AstDat" );
         ((GXEdit) edtAstDatFalecimento.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtAstDatFalecimento.addFocusListener(this);
         edtAstDatFalecimento.getGXComponent().setHelpId("HLP_TAstro.htm");
         lbllbl5 = UIFactory.getLabel(tpagetpage4.getGXPanel(), "Cadastro de astros", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 26 , 107 , 13 );
         lbllbl7 = UIFactory.getLabel(tpagetpage4.getGXPanel(), "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 82 , 40 , 13 );
         lbllbl9 = UIFactory.getLabel(tpagetpage4.getGXPanel(), "Nome completo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 108 , 88 , 13 );
         lbllbl10 = UIFactory.getLabel(tpagetpage4.getGXPanel(), "Data de nascimento", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 160 , 114 , 13 );
         lbllbl11 = UIFactory.getLabel(tpagetpage4.getGXPanel(), "Data de falecimento", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 186 , 115 , 13 );
         tpagetpage14 = new GXTabPage ( tctrltctrl3 , "Sobre" , 5 , 29 , 555 , 258 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         edtAstDescricao = new GUIObjectString ( new GXEdit(800, "@!", UIFactory.getFont( "Courier New", 0, 9),39, 65, 481, 169, tpagetpage14.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.LONGVARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage14.getGXPanel() , 39 , 65 , 481 , 169 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A53AstDesc" );
         ((GXEdit) edtAstDescricao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtAstDescricao.addFocusListener(this);
         edtAstDescricao.getGXComponent().setHelpId("HLP_TAstro.htm");
         lbllbl15 = UIFactory.getLabel(tpagetpage14.getGXPanel(), "Descrição do astro", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 26 , 108 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtAstCodigo ,
                   edtAstNome ,
                   edtAstDatNascimento ,
                   edtAstDatFalecimento ,
                   edtAstDescricao ,
                   bttbtt2
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Astcodigo();
         setFocus(edtAstNome, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey0810( ) ;
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt2.setGXEnabled(0);
            edtAstCodigo.setEnabled(0);
            edtAstNome.setEnabled(0);
            edtAstDatFalecimento.setEnabled(0);
            edtAstDatNascimento.setEnabled(0);
            edtAstDescricao.setEnabled(0);
            setFocus(bttbtt2, true);
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
            bttbtt2.setCaption(GXResourceManager.GetMessage("captionconfirm"));
            bttbtt2.setTooltip(GXResourceManager.GetMessage("captionconfirm"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt2.setCaption(GXResourceManager.GetMessage("captionadd"));
            bttbtt2.setTooltip(GXResourceManager.GetMessage("captionadd"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt2.setCaption(GXResourceManager.GetMessage("captionupdate"));
            bttbtt2.setTooltip(GXResourceManager.GetMessage("captionupdate"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt2.setCaption(GXResourceManager.GetMessage("captiondelete"));
            bttbtt2.setTooltip(GXResourceManager.GetMessage("captiondelete"));
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
                  InitAll0810( ) ;
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
         if ( bttbtt2.isEventSource(eventSource) ) {
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
         if ( edtAstCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtAstCodigo.getGXCursor() );
            return;
         }
         if ( edtAstNome.isEventSource(eventSource) ) {
            setGXCursor( edtAstNome.getGXCursor() );
            return;
         }
         if ( edtAstDatFalecimento.isEventSource(eventSource) ) {
            setGXCursor( edtAstDatFalecimento.getGXCursor() );
            return;
         }
         if ( edtAstDatNascimento.isEventSource(eventSource) ) {
            setGXCursor( edtAstDatNascimento.getGXCursor() );
            return;
         }
         if ( edtAstDescricao.isEventSource(eventSource) ) {
            setGXCursor( edtAstDescricao.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( edtAstDatNascimento.isEventSource(eventSource) ) {
            Valid_Astdatnascimento ();
            return;
         }
         if ( edtAstDatFalecimento.isEventSource(eventSource) ) {
            Valid_Astdatfalecimento ();
            return;
         }
         if ( edtAstNome.isEventSource(eventSource) ) {
            Valid_Astnome ();
            return;
         }
         if ( edtAstCodigo.isEventSource(eventSource) ) {
            Valid_Astcodigo ();
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtAstCodigo.isEventSource(eventSource) ) {
            A49AstCodi = edtAstCodigo.getValue() ;
            return;
         }
         if ( edtAstNome.isEventSource(eventSource) ) {
            A50AstNome = edtAstNome.getValue() ;
            n50AstNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A50AstNome).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtAstDatFalecimento.isEventSource(eventSource) ) {
            A114AstDat = edtAstDatFalecimento.getValue() ;
            n114AstDat = (((DateTime.MinValue==A114AstDat)) ? true : false) ;
            return;
         }
         if ( edtAstDatNascimento.isEventSource(eventSource) ) {
            A113AstDat = edtAstDatNascimento.getValue() ;
            n113AstDat = (((DateTime.MinValue==A113AstDat)) ? true : false) ;
            return;
         }
         if ( edtAstDescricao.isEventSource(eventSource) ) {
            A53AstDesc = edtAstDescricao.getValue() ;
            n53AstDesc = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A53AstDesc).TrimEnd(' ') )==0)) ? true : false) ;
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
         return false;
      }

      public override bool isKeyControl( Object eventSource )
      {
         if ( ( edtAstCodigo.isEventSource(eventSource) ) && ( ( A49AstCodi != edtAstCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
         if ( ( edtAstNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A50AstNome.TrimEnd(' '), edtAstNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtAstDatFalecimento.isEventSource(eventSource) ) && ( ( A114AstDat != edtAstDatFalecimento.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtAstDatNascimento.isEventSource(eventSource) ) && ( ( A113AstDat != edtAstDatNascimento.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtAstDescricao.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A53AstDesc.TrimEnd(' '), edtAstDescricao.getValue().TrimEnd(' ') ) != 0 ) ) )
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
         ResetCaption080( ) ;
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
         return bttbtt2 ;
      }

      public bool promptHandler( Object eventSource )
      {
         return false;
      }

      public override void deleteLineHandler( Object eventSource ,
                                              int row )
      {
      }

      public override void setNoAccept( Object eventSource )
      {
         if ( edtAstNome.isEventSource(eventSource) )
         {
            edtAstNome.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtAstDatFalecimento.isEventSource(eventSource) )
         {
            edtAstDatFalecimento.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtAstDatNascimento.isEventSource(eventSource) )
         {
            edtAstDatNascimento.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtAstDescricao.isEventSource(eventSource) )
         {
            edtAstDescricao.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      public override void VariablesToControls( )
      {
         edtAstCodigo.setValue( A49AstCodi );
         edtAstNome.setValue( A50AstNome );
         edtAstDatFalecimento.setValue( A114AstDat );
         edtAstDatNascimento.setValue( A113AstDat );
         edtAstDescricao.setValue( A53AstDesc );
      }

      public override void ControlsToVariables( )
      {
         A49AstCodi = (int)(edtAstCodigo.getValue()) ;
         edtAstCodigo.setValue(A49AstCodi);
         A50AstNome = (String)(edtAstNome.getValue()) ;
         edtAstNome.setValue(A50AstNome);
         n50AstNome = false ;
         n50AstNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A50AstNome).TrimEnd(' ') )==0)) ? true : false) ;
         A114AstDat = (DateTime)(edtAstDatFalecimento.getValue()) ;
         edtAstDatFalecimento.setValue(A114AstDat);
         n114AstDat = false ;
         n114AstDat = (((DateTime.MinValue==A114AstDat)) ? true : false) ;
         A113AstDat = (DateTime)(edtAstDatNascimento.getValue()) ;
         edtAstDatNascimento.setValue(A113AstDat);
         n113AstDat = false ;
         n113AstDat = (((DateTime.MinValue==A113AstDat)) ? true : false) ;
         A53AstDesc = (String)(edtAstDescricao.getValue()) ;
         edtAstDescricao.setValue(A53AstDesc);
         n53AstDesc = false ;
         n53AstDesc = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A53AstDesc).TrimEnd(' ') )==0)) ? true : false) ;
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

      protected void Valid_Astcodigo( )
      {
         if ( ( A49AstCodi != K49AstCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K49AstCodi = A49AstCodi ;
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

      protected void Valid_Astnome( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A50AstNome).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Nome deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtAstNome );
            setFocusNext();
         }
      }

      protected void Valid_Astdatnascimento( )
      {
         if ( ! ( ((DateTime.MinValue==A113AstDat)) || ( A113AstDat >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXutil.msg( me(), "Campo Data de nascimento do astro de cinema fora da faixa" );
            AnyError = 1 ;
            setNextFocus( edtAstDatNascimento );
            setFocusNext();
         }
      }

      protected void Valid_Astdatfalecimento( )
      {
         if ( ! ( ((DateTime.MinValue==A114AstDat)) || ( A114AstDat >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXutil.msg( me(), "Campo Data de falecimento do astro de cinema fora da faixa" );
            AnyError = 1 ;
            setNextFocus( edtAstDatFalecimento );
            setFocusNext();
         }
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
               sMode10 = Gx_mode ;
               Gx_mode = "UPD" ;
               Gx_mode = sMode10 ;
            }
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               getByPrimaryKey( ) ;
               if ( ( RcdFound10 != 1 ) )
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
         PreviousCaption = bttbtt2.getCaption() ;
      }

      protected void ZM0810( int GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z50AstNome = T00083_A50AstNome[0] ;
               Z113AstDat = T00083_A113AstDat[0] ;
               Z114AstDat = T00083_A114AstDat[0] ;
            }
            else
            {
               Z50AstNome = A50AstNome ;
               Z113AstDat = A113AstDat ;
               Z114AstDat = A114AstDat ;
            }
         }
         if ( ( GX_JID == -4 ) )
         {
            Z49AstCodi = A49AstCodi ;
            Z50AstNome = A50AstNome ;
            Z113AstDat = A113AstDat ;
            Z114AstDat = A114AstDat ;
            Z53AstDesc = A53AstDesc ;
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

      protected void Load0810( )
      {
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A49AstCodi});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound10 = 1 ;
            A50AstNome = T00084_A50AstNome[0] ;
            n50AstNome = T00084_n50AstNome[0] ;
            A113AstDat = T00084_A113AstDat[0] ;
            n113AstDat = T00084_n113AstDat[0] ;
            A114AstDat = T00084_A114AstDat[0] ;
            n114AstDat = T00084_n114AstDat[0] ;
            A53AstDesc = T00084_A53AstDesc[0] ;
            n53AstDesc = T00084_n53AstDesc[0] ;
            ZM0810( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0810( ) ;
      }

      protected void OnLoadActions0810( )
      {
      }

      protected void CheckExtendedTable0810( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A50AstNome).TrimEnd(' ') )==0)) )
         {
            pushError( "Nome deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( ! ( ((DateTime.MinValue==A113AstDat)) || ( A113AstDat >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            pushError( "Campo Data de nascimento do astro de cinema fora da faixa" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( ! ( ((DateTime.MinValue==A114AstDat)) || ( A114AstDat >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            pushError( "Campo Data de falecimento do astro de cinema fora da faixa" );
            AnyError = 1 ;
            keepFocus();
         }
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors0810( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0810( )
      {
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {A49AstCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound10 = 1 ;
         }
         else
         {
            RcdFound10 = 0 ;
         }
         pr_default.close(3);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A49AstCodi});
         if ( (pr_default.getStatus(1) != 101) && ( T00083_A49AstCodi[0] == A49AstCodi ) )
         {
            ZM0810( 4) ;
            RcdFound10 = 1 ;
            A50AstNome = T00083_A50AstNome[0] ;
            n50AstNome = T00083_n50AstNome[0] ;
            A113AstDat = T00083_A113AstDat[0] ;
            n113AstDat = T00083_n113AstDat[0] ;
            A114AstDat = T00083_A114AstDat[0] ;
            n114AstDat = T00083_n114AstDat[0] ;
            A53AstDesc = T00083_A53AstDesc[0] ;
            n53AstDesc = T00083_n53AstDesc[0] ;
            Z49AstCodi = A49AstCodi ;
            sMode10 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load0810( ) ;
            Gx_mode = sMode10 ;
         }
         else
         {
            RcdFound10 = 0 ;
            InitializeNonKey0810( ) ;
            sMode10 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode10 ;
         }
         K49AstCodi = A49AstCodi ;
         pr_default.close(1);
      }

      public override void getEqualNoModal( )
      {
         GetKey0810( ) ;
         if ( ( RcdFound10 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound10 = 0 ;
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A49AstCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( T00086_A49AstCodi[0] == A49AstCodi ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( T00086_A49AstCodi[0] == A49AstCodi ) )
            {
               RcdFound10 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0 ;
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A49AstCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( T00087_A49AstCodi[0] == A49AstCodi ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( T00087_A49AstCodi[0] == A49AstCodi ) )
            {
               RcdFound10 = 1 ;
            }
         }
         pr_default.close(5);
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
         GetKey0810( ) ;
         if ( ( RcdFound10 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( edtAstCodigo );
            }
            else if ( ( A49AstCodi != Z49AstCodi ) )
            {
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtAstCodigo );
            }
            else
            {
               /* Update record */
               Update0810( ) ;
               setNextFocus( edtAstCodigo );
            }
         }
         else
         {
            if ( ( A49AstCodi != Z49AstCodi ) )
            {
               /* Insert record */
               Insert0810( ) ;
               setNextFocus( edtAstCodigo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( edtAstCodigo );
               }
               else
               {
                  /* Insert record */
                  Insert0810( ) ;
                  setNextFocus( edtAstCodigo );
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
         if ( ( A49AstCodi != Z49AstCodi ) )
         {
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtAstCodigo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( edtAstCodigo );
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

      protected void CheckOptimisticConcurrency0810( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00082 */
            pr_default.execute(0, new Object[] {A49AstCodi});
            if ( ! (pr_default.getStatus(0) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"ASTRO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( String.CompareOrdinal(Z50AstNome.TrimEnd(' '), T00082_A50AstNome[0].TrimEnd(' ') ) != 0 ) || ( Z113AstDat != T00082_A113AstDat[0] ) || ( Z114AstDat != T00082_A114AstDat[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"ASTRO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert0810( )
      {
         BeforeValidate0810( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable0810( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM0810( 0) ;
            CheckOptimisticConcurrency0810( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0810( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert0810( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T00088 */
                     pr_default.execute(6, new Object[] {n50AstNome, A50AstNome, n113AstDat, A113AstDat, n114AstDat, A114AstDat, n53AstDesc, A53AstDesc});
                     pr_default.close(6);
                     /* Retrieving last key number assigned */
                     /* Using cursor T00089 */
                     pr_default.execute(7);
                     A49AstCodi = T00089_A49AstCodi[0] ;
                     pr_default.close(7);
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
               Load0810( ) ;
            }
            EndLevel0810( ) ;
         }
         CloseExtendedTableCursors0810( ) ;
      }

      protected void Update0810( )
      {
         BeforeValidate0810( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable0810( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency0810( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0810( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate0810( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000810 */
                     pr_default.execute(8, new Object[] {n50AstNome, A50AstNome, n113AstDat, A113AstDat, n114AstDat, A114AstDat, n53AstDesc, A53AstDesc, A49AstCodi});
                     pr_default.close(8);
                     DeferredUpdate0810( ) ;
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
            EndLevel0810( ) ;
         }
         CloseExtendedTableCursors0810( ) ;
      }

      protected void DeferredUpdate0810( )
      {
      }

      public override void delete( )
      {
         BeforeValidate0810( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency0810( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls0810( ) ;
            /* No cascading delete specified. */
            AfterConfirm0810( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete0810( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000811 */
                  pr_default.execute(9, new Object[] {A49AstCodi});
                  pr_default.close(9);
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
         sMode10 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel0810( ) ;
         Gx_mode = sMode10 ;
      }

      protected void OnDeleteControls0810( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000812 */
            pr_default.execute(10, new Object[] {A49AstCodi});
            if ( (pr_default.getStatus(10) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Direção do filme"}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(10);
            /* Using cursor T000813 */
            pr_default.execute(11, new Object[] {A49AstCodi});
            if ( (pr_default.getStatus(11) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Elenco do filme"}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0810( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(0);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete0810( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(1);
            context.CommitDataStores("TAstro");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("TAstro");
         }
         IsModified = 0 ;
      }

      protected void ScanStart0810( )
      {
         /* Using cursor T000814 */
         pr_default.execute(12, new Object[] {A49AstCodi});
         RcdFound10 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound10 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0810( )
      {
         pr_default.readNext(12);
         RcdFound10 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound10 = 1 ;
         }
      }

      protected void ScanEnd0810( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm0810( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0810( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0810( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0810( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0810( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0810( )
      {
         /* Before Validate Rules */
      }

      protected void CONFIRM_080( )
      {
         BeforeValidate0810( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls0810( ) ;
            }
            else
            {
               CheckExtendedTable0810( ) ;
               CloseExtendedTableCursors0810( ) ;
            }
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            PreviousCaption = bttbtt2.getCaption() ;
            PreviousTooltip = bttbtt2.getTooltip() ;
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         IsConfirmed = 0 ;
         IsModified = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         A50AstNome = "" ;
         n50AstNome = false ;
         A113AstDat = (DateTime)(DateTime.MinValue) ;
         n113AstDat = false ;
         A114AstDat = (DateTime)(DateTime.MinValue) ;
         n114AstDat = false ;
         A53AstDesc = "" ;
         n53AstDesc = false ;
         lastAnyError = 0 ;
         sMode10 = "" ;
         RcdFound10 = 0 ;
         Z50AstNome = "" ;
         Z113AstDat = (DateTime)(DateTime.MinValue) ;
         Z114AstDat = (DateTime)(DateTime.MinValue) ;
         scmdbuf = "" ;
         GX_JID = 0 ;
         Z49AstCodi = 0 ;
         Z53AstDesc = "" ;
         T00084_A49AstCodi = new int[1] ;
         T00084_A50AstNome = new String[] {""} ;
         T00084_n50AstNome = new bool[] {false} ;
         T00084_A113AstDat = new DateTime[] {DateTime.MinValue} ;
         T00084_n113AstDat = new bool[] {false} ;
         T00084_A114AstDat = new DateTime[] {DateTime.MinValue} ;
         T00084_n114AstDat = new bool[] {false} ;
         T00084_A53AstDesc = new String[] {""} ;
         T00084_n53AstDesc = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00085_A49AstCodi = new int[1] ;
         T00083_A49AstCodi = new int[1] ;
         T00083_A50AstNome = new String[] {""} ;
         T00083_n50AstNome = new bool[] {false} ;
         T00083_A113AstDat = new DateTime[] {DateTime.MinValue} ;
         T00083_n113AstDat = new bool[] {false} ;
         T00083_A114AstDat = new DateTime[] {DateTime.MinValue} ;
         T00083_n114AstDat = new bool[] {false} ;
         T00083_A53AstDesc = new String[] {""} ;
         T00083_n53AstDesc = new bool[] {false} ;
         T00086_A49AstCodi = new int[1] ;
         T00087_A49AstCodi = new int[1] ;
         T00082_A49AstCodi = new int[1] ;
         T00082_A50AstNome = new String[] {""} ;
         T00082_n50AstNome = new bool[] {false} ;
         T00082_A113AstDat = new DateTime[] {DateTime.MinValue} ;
         T00082_n113AstDat = new bool[] {false} ;
         T00082_A114AstDat = new DateTime[] {DateTime.MinValue} ;
         T00082_n114AstDat = new bool[] {false} ;
         T00082_A53AstDesc = new String[] {""} ;
         T00082_n53AstDesc = new bool[] {false} ;
         T00089_A49AstCodi = new int[1] ;
         T000812_A28FilCodi = new int[1] ;
         T000812_A79FilDirC = new int[1] ;
         T000813_A28FilCodi = new int[1] ;
         T000813_A77FilAtoC = new int[1] ;
         T000814_A49AstCodi = new int[1] ;
         K49AstCodi = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tastro__default(),
            new Object[][] {
                new Object[] {
               T00082_A49AstCodi, T00082_A50AstNome, T00082_n50AstNome, T00082_A113AstDat, T00082_n113AstDat, T00082_A114AstDat, T00082_n114AstDat, T00082_A53AstDesc, T00082_n53AstDesc
               }
               , new Object[] {
               T00083_A49AstCodi, T00083_A50AstNome, T00083_n50AstNome, T00083_A113AstDat, T00083_n113AstDat, T00083_A114AstDat, T00083_n114AstDat, T00083_A53AstDesc, T00083_n53AstDesc
               }
               , new Object[] {
               T00084_A49AstCodi, T00084_A50AstNome, T00084_n50AstNome, T00084_A113AstDat, T00084_n113AstDat, T00084_A114AstDat, T00084_n114AstDat, T00084_A53AstDesc, T00084_n53AstDesc
               }
               , new Object[] {
               T00085_A49AstCodi
               }
               , new Object[] {
               T00086_A49AstCodi
               }
               , new Object[] {
               T00087_A49AstCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T00089_A49AstCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000812_A28FilCodi, T000812_A79FilDirC
               }
               , new Object[] {
               T000813_A28FilCodi, T000813_A77FilAtoC
               }
               , new Object[] {
               T000814_A49AstCodi
               }
            }
         );
         reloadDynamicLists(0);
         K49AstCodi = 0 ;
         edtAstCodigo.setValue(A49AstCodi);
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short geteqAfterKey= 1 ;
      protected short RcdFound10 ;
      protected short Gx_BScreen ;
      protected int trnEnded ;
      protected int K49AstCodi ;
      protected int A49AstCodi ;
      protected int lastAnyError ;
      protected int GX_JID ;
      protected int Z49AstCodi ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String sMode10 ;
      protected String scmdbuf ;
      protected DateTime A113AstDat ;
      protected DateTime A114AstDat ;
      protected DateTime Z113AstDat ;
      protected DateTime Z114AstDat ;
      protected bool n50AstNome ;
      protected bool n113AstDat ;
      protected bool n114AstDat ;
      protected bool n53AstDesc ;
      protected String A53AstDesc ;
      protected String Z53AstDesc ;
      protected String A50AstNome ;
      protected String Z50AstNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected IGXButton bttbtt2 ;
      protected GXTabControl tctrltctrl3 ;
      protected GXTabPage tpagetpage4 ;
      protected GUIObjectInt edtAstCodigo ;
      protected GUIObjectString edtAstNome ;
      protected GUIObjectDatetime edtAstDatNascimento ;
      protected GUIObjectDatetime edtAstDatFalecimento ;
      protected ILabel lbllbl5 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl11 ;
      protected GXTabPage tpagetpage14 ;
      protected GUIObjectString edtAstDescricao ;
      protected ILabel lbllbl15 ;
      protected IDataReader T00082 ;
      protected IDataReader T00083 ;
      protected IDataReader T00084 ;
      protected IDataStoreProvider pr_default ;
      protected int[] T00084_A49AstCodi ;
      protected String[] T00084_A50AstNome ;
      protected bool[] T00084_n50AstNome ;
      protected DateTime[] T00084_A113AstDat ;
      protected bool[] T00084_n113AstDat ;
      protected DateTime[] T00084_A114AstDat ;
      protected bool[] T00084_n114AstDat ;
      protected String[] T00084_A53AstDesc ;
      protected bool[] T00084_n53AstDesc ;
      protected IDataReader T00085 ;
      protected int[] T00085_A49AstCodi ;
      protected int[] T00083_A49AstCodi ;
      protected String[] T00083_A50AstNome ;
      protected bool[] T00083_n50AstNome ;
      protected DateTime[] T00083_A113AstDat ;
      protected bool[] T00083_n113AstDat ;
      protected DateTime[] T00083_A114AstDat ;
      protected bool[] T00083_n114AstDat ;
      protected String[] T00083_A53AstDesc ;
      protected bool[] T00083_n53AstDesc ;
      protected IDataReader T00086 ;
      protected int[] T00086_A49AstCodi ;
      protected IDataReader T00087 ;
      protected int[] T00087_A49AstCodi ;
      protected int[] T00082_A49AstCodi ;
      protected String[] T00082_A50AstNome ;
      protected bool[] T00082_n50AstNome ;
      protected DateTime[] T00082_A113AstDat ;
      protected bool[] T00082_n113AstDat ;
      protected DateTime[] T00082_A114AstDat ;
      protected bool[] T00082_n114AstDat ;
      protected String[] T00082_A53AstDesc ;
      protected bool[] T00082_n53AstDesc ;
      protected IDataReader T00089 ;
      protected int[] T00089_A49AstCodi ;
      protected IDataReader T000812 ;
      protected int[] T000812_A28FilCodi ;
      protected int[] T000812_A79FilDirC ;
      protected IDataReader T000813 ;
      protected int[] T000813_A28FilCodi ;
      protected int[] T000813_A77FilAtoC ;
      protected IDataReader T000814 ;
      protected int[] T000814_A49AstCodi ;
   }

   public class tastro__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[6])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[7])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00084 ;
          prmT00084 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00085 ;
          prmT00085 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00083 ;
          prmT00083 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00086 ;
          prmT00086 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00087 ;
          prmT00087 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00082 ;
          prmT00082 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00088 ;
          prmT00088 = new Object[] {
          new Object[] {"@AstNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AstDatNascimento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AstDatFalecimento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AstDescricao",SqlDbType.Text,800,0}
          } ;
          Object[] prmT00089 ;
          prmT00089 = new Object[] {
          } ;
          Object[] prmT000810 ;
          prmT000810 = new Object[] {
          new Object[] {"@AstNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AstDatNascimento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AstDatFalecimento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AstDescricao",SqlDbType.Text,800,0} ,
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000811 ;
          prmT000811 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000812 ;
          prmT000812 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000813 ;
          prmT000813 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000814 ;
          prmT000814 = new Object[] {
          new Object[] {"@AstCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00082", "SELECT [AstCodigo], [AstNome], [AstDatNascimento], [AstDatFalecimento], [AstDescricao] FROM [ASTRO] WITH (UPDLOCK) WHERE [AstCodigo] = @AstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00083", "SELECT [AstCodigo], [AstNome], [AstDatNascimento], [AstDatFalecimento], [AstDescricao] FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @AstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00084", "SELECT TM1.[AstCodigo], TM1.[AstNome], TM1.[AstDatNascimento], TM1.[AstDatFalecimento], TM1.[AstDescricao] FROM [ASTRO] TM1 WITH (NOLOCK) WHERE TM1.[AstCodigo] = @AstCodigo ORDER BY TM1.[AstCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00085", "SELECT [AstCodigo] FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @AstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00086", "SELECT TOP 1 [AstCodigo] FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @AstCodigo ORDER BY [AstCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00087", "SELECT TOP 1 [AstCodigo] FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @AstCodigo ORDER BY [AstCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00088", "INSERT INTO [ASTRO] ([AstNome], [AstDatNascimento], [AstDatFalecimento], [AstDescricao]) VALUES (@AstNome, @AstDatNascimento, @AstDatFalecimento, @AstDescricao)", GxErrorMask.GX_NOMASK,prmT00088)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00089", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT00089,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000810", "UPDATE [ASTRO] SET [AstNome]=@AstNome, [AstDatNascimento]=@AstDatNascimento, [AstDatFalecimento]=@AstDatFalecimento, [AstDescricao]=@AstDescricao  WHERE [AstCodigo] = @AstCodigo", GxErrorMask.GX_NOMASK,prmT000810)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000811", "DELETE FROM [ASTRO]  WHERE [AstCodigo] = @AstCodigo", GxErrorMask.GX_NOMASK,prmT000811)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000812", "SELECT TOP 1 [FilCodigo], [FilDirCodigo] FROM [FILMEDIRECAO] WITH (NOLOCK) WHERE [FilDirCodigo] = @AstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000812,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000813", "SELECT TOP 1 [FilCodigo], [FilAtoCodigo] FROM [FILMEELENCO] WITH (NOLOCK) WHERE [FilAtoCodigo] = @AstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000813,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000814", "SELECT [AstCodigo] FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @AstCodigo ORDER BY [AstCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000814,100,0,true,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 12 :
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
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
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(2, (DateTime)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Text );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                break;
             case 8 :
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
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(2, (DateTime)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Text );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                stmt.SetParameter(5, (int)parms[8]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
