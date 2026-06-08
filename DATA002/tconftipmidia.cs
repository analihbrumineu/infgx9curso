/*
               File: ConfTipMidia
        Description: Configurações tipo de mídia.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/8/2026 11:43:16.14
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
   public class tconftipmidia : GXTransaction
   {
      public tconftipmidia( int hnd ,
                            ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tconftipmidia( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tconftipmidia( IGxContext context ,
                            int hnd ,
                            ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey0911( )
      {
         A85ConfTip = (decimal)(0M) ;
         n85ConfTip = false ;
         n85ConfTip = (((Convert.ToDecimal(0M)==A85ConfTip)) ? true : false) ;
      }

      protected void InitAll0911( )
      {
         A35MidTipo = 0 ;
         A32CatCodi = 0 ;
         K35MidTipo = A35MidTipo ;
         K32CatCodi = A32CatCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey0911( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void ResetCaption090( )
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
         return "ConfTipMidia" ;
      }

      public override String getFrmTitle( )
      {
         return "Configurações tipo de mídia." ;
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
         return 507 ;
      }

      public override int getFrmHeight( )
      {
         return 221 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TConfTipMidia.htm";
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

      public void execute( String aP0_Gx_mode )
      {
         this.Gx_mode = aP0_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 507 , 221 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         cmbMidTipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 130 , 78 , 78 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A35MidTipo" );
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(4),"Box");
         cmbMidTipo.addFocusListener(this);
         cmbMidTipo.addItemListener(this);
         cmbMidTipo.getGXComponent().setHelpId("HLP_TConfTipMidia.htm");
         edtCatCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),130, 104, 78, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 130 , 104 , 78 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A32CatCodi" );
         ((GXEdit) edtCatCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtCatCodigo.addFocusListener(this);
         edtCatCodigo.getGXComponent().setHelpId("HLP_TConfTipMidia.htm");
         edtConfTipValor = new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),130, 130, 108, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 130 , 130 , 108 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A85ConfTip" );
         ((GXEdit) edtConfTipValor.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtConfTipValor.addFocusListener(this);
         edtConfTipValor.getGXComponent().setHelpId("HLP_TConfTipMidia.htm");
         bttbtt3 = UIFactory.getGXButton( GXPanel1 , "Enter" ,  351 ,  169 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt3.setTooltip("Enter");
         bttbtt3.addActionListener(this);
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Configuração de tipo de mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 172 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Formato", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 82 , 46 , 13 );
         lbllbl5 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 108 , 55 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Valor (R$)", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 134 , 58 , 13 );
         edtCatCodigo.addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         focusManager.setControlList(new IFocusableControl[] {
                   cmbMidTipo ,
                   edtCatCodigo ,
                   edtConfTipValor ,
                   bttbtt3
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(cmbMidTipo, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey0911( ) ;
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt3.setGXEnabled(0);
            edtCatCodigo.setEnabled(0);
            cmbMidTipo.setEnabled(0);
            edtConfTipValor.setEnabled(0);
            setFocus(bttbtt3, true);
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
            bttbtt3.setCaption(GXResourceManager.GetMessage("captionconfirm"));
            bttbtt3.setTooltip(GXResourceManager.GetMessage("captionconfirm"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt3.setCaption(GXResourceManager.GetMessage("captionadd"));
            bttbtt3.setTooltip(GXResourceManager.GetMessage("captionadd"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt3.setCaption(GXResourceManager.GetMessage("captionupdate"));
            bttbtt3.setTooltip(GXResourceManager.GetMessage("captionupdate"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt3.setCaption(GXResourceManager.GetMessage("captiondelete"));
            bttbtt3.setTooltip(GXResourceManager.GetMessage("captiondelete"));
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
                  InitAll0911( ) ;
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
         if ( bttbtt3.isEventSource(eventSource) ) {
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
         if ( edtCatCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtCatCodigo.getGXCursor() );
            return;
         }
         if ( cmbMidTipo.isEventSource(eventSource) ) {
            setGXCursor( cmbMidTipo.getGXCursor() );
            return;
         }
         if ( edtConfTipValor.isEventSource(eventSource) ) {
            setGXCursor( edtConfTipValor.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( cmbMidTipo.isEventSource(eventSource) ) {
            Valid_Midtipo ();
            return;
         }
         if ( edtCatCodigo.isEventSource(eventSource) ) {
            Valid_Catcodigo ();
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtCatCodigo.isEventSource(eventSource) ) {
            A32CatCodi = edtCatCodigo.getValue() ;
            return;
         }
         if ( cmbMidTipo.isEventSource(eventSource) ) {
            A35MidTipo = cmbMidTipo.getValue() ;
            return;
         }
         if ( edtConfTipValor.isEventSource(eventSource) ) {
            A85ConfTip = edtConfTipValor.getValue() ;
            n85ConfTip = (((Convert.ToDecimal(0M)==A85ConfTip)) ? true : false) ;
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
            /* Execute user event: E11092 */
            E11092 ();
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
         if ( ( cmbMidTipo.isEventSource(eventSource) ) && ( ( A35MidTipo != cmbMidTipo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtCatCodigo.isEventSource(eventSource) ) && ( ( A32CatCodi != edtCatCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
         if ( ( edtConfTipValor.isEventSource(eventSource) ) && ( ( A85ConfTip != edtConfTipValor.getValue() ) ) )
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
         ResetCaption090( ) ;
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
         return bttbtt3 ;
      }

      public bool promptHandler( Object eventSource )
      {
         if (( edtCatCodigo.isEventSource(eventSource) ) && ( edtCatCodigo.isEnabled() )) {
            prompt_32_11( ) ;
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
         if ( edtConfTipValor.isEventSource(eventSource) )
         {
            edtConfTipValor.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      public override void VariablesToControls( )
      {
         edtCatCodigo.setValue( A32CatCodi );
         cmbMidTipo.setValue( A35MidTipo );
         edtConfTipValor.setValue( A85ConfTip );
      }

      public override void ControlsToVariables( )
      {
         A32CatCodi = (int)(edtCatCodigo.getValue()) ;
         edtCatCodigo.setValue(A32CatCodi);
         A35MidTipo = (short)(cmbMidTipo.getValue()) ;
         cmbMidTipo.setValue(A35MidTipo);
         A85ConfTip = (decimal)(edtConfTipValor.getValue()) ;
         edtConfTipValor.setValue(A85ConfTip);
         n85ConfTip = false ;
         n85ConfTip = (((Convert.ToDecimal(0M)==A85ConfTip)) ? true : false) ;
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

      protected void prompt_32_11( )
      {
         new wgx0060(context, base.remoteHandle, base.context).execute( out  A32CatCodi) ;
         edtCatCodigo.setValue( A32CatCodi );
         setFocus(edtCatCodigo);
         ResetCaption090( ) ;
      }

      protected void Valid_Midtipo( )
      {
      }

      protected void Valid_Catcodigo( )
      {
         if ( ( A35MidTipo != K35MidTipo ) || ( A32CatCodi != K32CatCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K35MidTipo = A35MidTipo ;
               K32CatCodi = A32CatCodi ;
               getEqualNoModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
               {
                  StandaloneModalInsert( ) ;
               }
               VariablesToControls();
            }
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {A32CatCodi});
            if ( (pr_default.getStatus(0) == 101) )
            {
               GXutil.msg( me(), "Não existe 'Cadastro de categorias.'." );
               AnyError = 1 ;
               setNextFocus( edtCatCodigo );
               setFocusNext();
            }
            pr_default.close(0);
            pr_default.close(0);
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

      protected void E11092( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A32CatCodi") )
         {
            new wconscategoria(context, base.remoteHandle, base.context).execute( out  A32CatCodi) ;
            edtCatCodigo.setValue( A32CatCodi );
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
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
            }
         }
         set_caption( ) ;
         PreviousCaption = bttbtt3.getCaption() ;
      }

      protected void ZM0911( int GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z85ConfTip = T00094_A85ConfTip[0] ;
            }
            else
            {
               Z85ConfTip = A85ConfTip ;
            }
         }
         if ( ( GX_JID == -1 ) )
         {
            Z35MidTipo = A35MidTipo ;
            Z85ConfTip = A85ConfTip ;
            Z32CatCodi = A32CatCodi ;
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

      protected void Load0911( )
      {
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {A35MidTipo, A32CatCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound11 = 1 ;
            A85ConfTip = T00095_A85ConfTip[0] ;
            n85ConfTip = T00095_n85ConfTip[0] ;
            ZM0911( -1) ;
         }
         pr_default.close(3);
         OnLoadActions0911( ) ;
      }

      protected void OnLoadActions0911( )
      {
      }

      protected void CheckExtendedTable0911( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         /* Using cursor T00092 */
         pr_default.execute(0, new Object[] {A32CatCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            pushError( "Não existe 'Cadastro de categorias.'." );
            AnyError = 1 ;
            setNextFocus( edtCatCodigo );
         }
         pr_default.close(0);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors0911( )
      {
         pr_default.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0911( )
      {
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A35MidTipo, A32CatCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound11 = 1 ;
         }
         else
         {
            RcdFound11 = 0 ;
         }
         pr_default.close(4);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A35MidTipo, A32CatCodi});
         if ( (pr_default.getStatus(2) != 101) )
         {
            ZM0911( 1) ;
            RcdFound11 = 1 ;
            A35MidTipo = T00094_A35MidTipo[0] ;
            A85ConfTip = T00094_A85ConfTip[0] ;
            n85ConfTip = T00094_n85ConfTip[0] ;
            A32CatCodi = T00094_A32CatCodi[0] ;
            Z35MidTipo = A35MidTipo ;
            Z32CatCodi = A32CatCodi ;
            sMode11 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load0911( ) ;
            Gx_mode = sMode11 ;
         }
         else
         {
            RcdFound11 = 0 ;
            InitializeNonKey0911( ) ;
            sMode11 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode11 ;
         }
         K35MidTipo = A35MidTipo ;
         K32CatCodi = A32CatCodi ;
         pr_default.close(2);
      }

      public override void getEqualNoModal( )
      {
         GetKey0911( ) ;
         if ( ( RcdFound11 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound11 = 0 ;
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A35MidTipo, A32CatCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00097_A35MidTipo[0] < A35MidTipo ) || ( T00097_A35MidTipo[0] == A35MidTipo ) && ( T00097_A32CatCodi[0] < A32CatCodi ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00097_A35MidTipo[0] > A35MidTipo ) || ( T00097_A35MidTipo[0] == A35MidTipo ) && ( T00097_A32CatCodi[0] > A32CatCodi ) ) )
            {
               A35MidTipo = T00097_A35MidTipo[0] ;
               A32CatCodi = T00097_A32CatCodi[0] ;
               RcdFound11 = 1 ;
            }
         }
         pr_default.close(5);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0 ;
         /* Using cursor T00098 */
         pr_default.execute(6, new Object[] {A35MidTipo, A32CatCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00098_A35MidTipo[0] > A35MidTipo ) || ( T00098_A35MidTipo[0] == A35MidTipo ) && ( T00098_A32CatCodi[0] > A32CatCodi ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00098_A35MidTipo[0] < A35MidTipo ) || ( T00098_A35MidTipo[0] == A35MidTipo ) && ( T00098_A32CatCodi[0] < A32CatCodi ) ) )
            {
               A35MidTipo = T00098_A35MidTipo[0] ;
               A32CatCodi = T00098_A32CatCodi[0] ;
               RcdFound11 = 1 ;
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
         GetKey0911( ) ;
         if ( ( RcdFound11 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( cmbMidTipo );
            }
            else if ( ( A35MidTipo != Z35MidTipo ) || ( A32CatCodi != Z32CatCodi ) )
            {
               A35MidTipo = Z35MidTipo ;
               cmbMidTipo.setValue(A35MidTipo);
               A32CatCodi = Z32CatCodi ;
               edtCatCodigo.setValue(A32CatCodi);
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( cmbMidTipo );
            }
            else
            {
               /* Update record */
               Update0911( ) ;
               setNextFocus( cmbMidTipo );
            }
         }
         else
         {
            if ( ( A35MidTipo != Z35MidTipo ) || ( A32CatCodi != Z32CatCodi ) )
            {
               /* Insert record */
               Insert0911( ) ;
               setNextFocus( cmbMidTipo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( cmbMidTipo );
               }
               else
               {
                  /* Insert record */
                  Insert0911( ) ;
                  setNextFocus( cmbMidTipo );
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
         if ( ( A35MidTipo != Z35MidTipo ) || ( A32CatCodi != Z32CatCodi ) )
         {
            A35MidTipo = Z35MidTipo ;
            cmbMidTipo.setValue(A35MidTipo);
            A32CatCodi = Z32CatCodi ;
            edtCatCodigo.setValue(A32CatCodi);
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( cmbMidTipo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( cmbMidTipo );
         }
         if ( ( AnyError != 0 ) )
         {
         }
         getByPrimaryKey( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
         CloseOpenCursors();
      }

      public override void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( ( RcdFound11 == 0 ) )
         {
            pushError( GXResourceManager.GetMessage("keynfound") );
            AnyError = 1 ;
            keepFocus();
         }
         setNextFocus( edtConfTipValor );
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0911( ) ;
         if ( ( RcdFound11 == 0 ) )
         {
            base.context.msgStatus(GXResourceManager.GetMessage("norectobrow"));
         }
         else
         {
         }
         setNextFocus( edtConfTipValor );
         ScanEnd0911( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( ( RcdFound11 == 0 ) )
         {
            base.context.msgStatus(GXResourceManager.GetMessage("norectobrow"));
         }
         else
         {
         }
         setNextFocus( edtConfTipValor );
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( ( RcdFound11 == 0 ) )
         {
            base.context.msgStatus(GXResourceManager.GetMessage("norectobrow"));
         }
         else
         {
         }
         setNextFocus( edtConfTipValor );
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0911( ) ;
         if ( ( RcdFound11 == 0 ) )
         {
            base.context.msgStatus(GXResourceManager.GetMessage("norectobrow"));
         }
         else
         {
            while ( ( RcdFound11 != 0 ) )
            {
               ScanNext0911( ) ;
            }
         }
         setNextFocus( edtConfTipValor );
         ScanEnd0911( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_select( )
      {
         new wgx00b0(context, base.remoteHandle, base.context).execute( out  A35MidTipo, out  A32CatCodi) ;
         cmbMidTipo.setValue( A35MidTipo );
         edtCatCodigo.setValue( A32CatCodi );
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0911( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00093 */
            pr_default.execute(1, new Object[] {A35MidTipo, A32CatCodi});
            if ( ! (pr_default.getStatus(1) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"CONFTIPMIDIA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(1) == 101) || ( Z85ConfTip != T00093_A85ConfTip[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"CONFTIPMIDIA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert0911( )
      {
         BeforeValidate0911( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable0911( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM0911( 0) ;
            CheckOptimisticConcurrency0911( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0911( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert0911( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T00099 */
                     pr_default.execute(7, new Object[] {A35MidTipo, n85ConfTip, A85ConfTip, A32CatCodi});
                     pr_default.close(7);
                     if ( (pr_default.getStatus(7) == 1) )
                     {
                        pushError( GXResourceManager.GetMessage("noupdate") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                           base.context.msgStatus(GXResourceManager.GetMessage("sucadded"));
                           ResetCaption090( ) ;
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
               Load0911( ) ;
            }
            EndLevel0911( ) ;
         }
         CloseExtendedTableCursors0911( ) ;
      }

      protected void Update0911( )
      {
         BeforeValidate0911( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable0911( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency0911( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0911( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate0911( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000910 */
                     pr_default.execute(8, new Object[] {n85ConfTip, A85ConfTip, A35MidTipo, A32CatCodi});
                     pr_default.close(8);
                     DeferredUpdate0911( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey( ) ;
                           base.context.msgStatus(GXResourceManager.GetMessage("sucupdated"));
                           ResetCaption090( ) ;
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
            EndLevel0911( ) ;
         }
         CloseExtendedTableCursors0911( ) ;
      }

      protected void DeferredUpdate0911( )
      {
      }

      public override void delete( )
      {
         BeforeValidate0911( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency0911( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls0911( ) ;
            /* No cascading delete specified. */
            AfterConfirm0911( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete0911( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000911 */
                  pr_default.execute(9, new Object[] {A35MidTipo, A32CatCodi});
                  pr_default.close(9);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        move_next( ) ;
                        if ( ( RcdFound11 == 0 ) )
                        {
                           InitAll0911( ) ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                        }
                        base.context.msgStatus(GXResourceManager.GetMessage("sucdeleted"));
                        ResetCaption090( ) ;
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
         sMode11 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel0911( ) ;
         Gx_mode = sMode11 ;
      }

      protected void OnDeleteControls0911( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0911( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(1);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete0911( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(2);
            context.CommitDataStores("TConfTipMidia");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(2);
            context.RollbackDataStores("TConfTipMidia");
         }
         IsModified = 0 ;
      }

      protected void ScanStart0911( )
      {
         /* Using cursor T000912 */
         pr_default.execute(10);
         RcdFound11 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound11 = 1 ;
            A35MidTipo = T000912_A35MidTipo[0] ;
            A32CatCodi = T000912_A32CatCodi[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0911( )
      {
         pr_default.readNext(10);
         RcdFound11 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound11 = 1 ;
            A35MidTipo = T000912_A35MidTipo[0] ;
            A32CatCodi = T000912_A32CatCodi[0] ;
         }
      }

      protected void ScanEnd0911( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0911( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0911( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0911( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0911( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0911( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0911( )
      {
         /* Before Validate Rules */
      }

      protected void CONFIRM_090( )
      {
         BeforeValidate0911( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls0911( ) ;
            }
            else
            {
               CheckExtendedTable0911( ) ;
               CloseExtendedTableCursors0911( ) ;
            }
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            PreviousCaption = bttbtt3.getCaption() ;
            PreviousTooltip = bttbtt3.getTooltip() ;
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
      }

      public override void initialize( )
      {
         IsConfirmed = 0 ;
         IsModified = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         A85ConfTip = (decimal)(0M) ;
         n85ConfTip = false ;
         A35MidTipo = 0 ;
         A32CatCodi = 0 ;
         K35MidTipo = 0 ;
         K32CatCodi = 0 ;
         lastAnyError = 0 ;
         scmdbuf = "" ;
         T00092_A32CatCodi = new int[1] ;
         Z85ConfTip = (decimal)(0M) ;
         GX_JID = 0 ;
         Z35MidTipo = 0 ;
         Z32CatCodi = 0 ;
         T00095_A35MidTipo = new short[1] ;
         T00095_A85ConfTip = new decimal[1] ;
         T00095_n85ConfTip = new bool[] {false} ;
         T00095_A32CatCodi = new int[1] ;
         RcdFound11 = 0 ;
         Gx_BScreen = 0 ;
         T00096_A35MidTipo = new short[1] ;
         T00096_A32CatCodi = new int[1] ;
         T00094_A35MidTipo = new short[1] ;
         T00094_A85ConfTip = new decimal[1] ;
         T00094_n85ConfTip = new bool[] {false} ;
         T00094_A32CatCodi = new int[1] ;
         sMode11 = "" ;
         T00097_A35MidTipo = new short[1] ;
         T00097_A32CatCodi = new int[1] ;
         T00098_A35MidTipo = new short[1] ;
         T00098_A32CatCodi = new int[1] ;
         T00093_A35MidTipo = new short[1] ;
         T00093_A85ConfTip = new decimal[1] ;
         T00093_n85ConfTip = new bool[] {false} ;
         T00093_A32CatCodi = new int[1] ;
         T000912_A35MidTipo = new short[1] ;
         T000912_A32CatCodi = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tconftipmidia__default(),
            new Object[][] {
                new Object[] {
               T00092_A32CatCodi
               }
               , new Object[] {
               T00093_A35MidTipo, T00093_A85ConfTip, T00093_n85ConfTip, T00093_A32CatCodi
               }
               , new Object[] {
               T00094_A35MidTipo, T00094_A85ConfTip, T00094_n85ConfTip, T00094_A32CatCodi
               }
               , new Object[] {
               T00095_A35MidTipo, T00095_A85ConfTip, T00095_n85ConfTip, T00095_A32CatCodi
               }
               , new Object[] {
               T00096_A35MidTipo, T00096_A32CatCodi
               }
               , new Object[] {
               T00097_A35MidTipo, T00097_A32CatCodi
               }
               , new Object[] {
               T00098_A35MidTipo, T00098_A32CatCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000912_A35MidTipo, T000912_A32CatCodi
               }
            }
         );
         reloadDynamicLists(0);
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short A35MidTipo ;
      protected short K35MidTipo ;
      protected short geteqAfterKey= 1 ;
      protected short Z35MidTipo ;
      protected short RcdFound11 ;
      protected short Gx_BScreen ;
      protected int trnEnded ;
      protected int A32CatCodi ;
      protected int K32CatCodi ;
      protected int lastAnyError ;
      protected int GX_JID ;
      protected int Z32CatCodi ;
      protected decimal A85ConfTip ;
      protected decimal Z85ConfTip ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String scmdbuf ;
      protected String sMode11 ;
      protected bool n85ConfTip ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectShort cmbMidTipo ;
      protected GUIObjectInt edtCatCodigo ;
      protected GUIObjectDecimal2 edtConfTipValor ;
      protected IGXButton bttbtt3 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl5 ;
      protected ILabel lbllbl8 ;
      protected IDataReader T00092 ;
      protected IDataStoreProvider pr_default ;
      protected int[] T00092_A32CatCodi ;
      protected IDataReader T00093 ;
      protected IDataReader T00094 ;
      protected IDataReader T00095 ;
      protected short[] T00095_A35MidTipo ;
      protected decimal[] T00095_A85ConfTip ;
      protected bool[] T00095_n85ConfTip ;
      protected int[] T00095_A32CatCodi ;
      protected IDataReader T00096 ;
      protected short[] T00096_A35MidTipo ;
      protected int[] T00096_A32CatCodi ;
      protected short[] T00094_A35MidTipo ;
      protected decimal[] T00094_A85ConfTip ;
      protected bool[] T00094_n85ConfTip ;
      protected int[] T00094_A32CatCodi ;
      protected IDataReader T00097 ;
      protected short[] T00097_A35MidTipo ;
      protected int[] T00097_A32CatCodi ;
      protected IDataReader T00098 ;
      protected short[] T00098_A35MidTipo ;
      protected int[] T00098_A32CatCodi ;
      protected short[] T00093_A35MidTipo ;
      protected decimal[] T00093_A85ConfTip ;
      protected bool[] T00093_n85ConfTip ;
      protected int[] T00093_A32CatCodi ;
      protected IDataReader T000912 ;
      protected short[] T000912_A35MidTipo ;
      protected int[] T000912_A32CatCodi ;
   }

   public class tconftipmidia__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00095 ;
          prmT00095 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00092 ;
          prmT00092 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00096 ;
          prmT00096 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00094 ;
          prmT00094 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00097 ;
          prmT00097 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00098 ;
          prmT00098 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00093 ;
          prmT00093 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00099 ;
          prmT00099 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ConfTipValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000910 ;
          prmT000910 = new Object[] {
          new Object[] {"@ConfTipValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000911 ;
          prmT000911 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000912 ;
          prmT000912 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00092", "SELECT [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00093", "SELECT [MidTipo], [ConfTipValor], [CatCodigo] FROM [CONFTIPMIDIA] WITH (UPDLOCK) WHERE [MidTipo] = @MidTipo AND [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00094", "SELECT [MidTipo], [ConfTipValor], [CatCodigo] FROM [CONFTIPMIDIA] WITH (NOLOCK) WHERE [MidTipo] = @MidTipo AND [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00095", "SELECT TM1.[MidTipo], TM1.[ConfTipValor], TM1.[CatCodigo] FROM [CONFTIPMIDIA] TM1 WITH (NOLOCK) WHERE TM1.[MidTipo] = @MidTipo and TM1.[CatCodigo] = @CatCodigo ORDER BY TM1.[MidTipo], TM1.[CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00096", "SELECT [MidTipo], [CatCodigo] FROM [CONFTIPMIDIA] WITH (NOLOCK) WHERE [MidTipo] = @MidTipo AND [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00097", "SELECT TOP 1 [MidTipo], [CatCodigo] FROM [CONFTIPMIDIA] WITH (NOLOCK) WHERE ( [MidTipo] > @MidTipo or [MidTipo] = @MidTipo and [CatCodigo] > @CatCodigo) ORDER BY [MidTipo], [CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00098", "SELECT TOP 1 [MidTipo], [CatCodigo] FROM [CONFTIPMIDIA] WITH (NOLOCK) WHERE ( [MidTipo] < @MidTipo or [MidTipo] = @MidTipo and [CatCodigo] < @CatCodigo) ORDER BY [MidTipo] DESC, [CatCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00099", "INSERT INTO [CONFTIPMIDIA] ([MidTipo], [ConfTipValor], [CatCodigo]) VALUES (@MidTipo, @ConfTipValor, @CatCodigo)", GxErrorMask.GX_NOMASK,prmT00099)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000910", "UPDATE [CONFTIPMIDIA] SET [ConfTipValor]=@ConfTipValor  WHERE [MidTipo] = @MidTipo AND [CatCodigo] = @CatCodigo", GxErrorMask.GX_NOMASK,prmT000910)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000911", "DELETE FROM [CONFTIPMIDIA]  WHERE [MidTipo] = @MidTipo AND [CatCodigo] = @CatCodigo", GxErrorMask.GX_NOMASK,prmT000911)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000912", "SELECT [MidTipo], [CatCodigo] FROM [CONFTIPMIDIA] WITH (NOLOCK) ORDER BY [MidTipo], [CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000912,100,0,true,false )
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
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (decimal)parms[2]);
                }
                stmt.SetParameter(3, (int)parms[3]);
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
