/*
               File: Categoria
        Description: Cadastro de categorias.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:18:7.79
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
   public class tcategoria : GXTransaction
   {
      public tcategoria( int hnd ,
                         ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tcategoria( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tcategoria( IGxContext context ,
                         int hnd ,
                         ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey036( )
      {
         A33CatNome = "" ;
         n33CatNome = false ;
         n33CatNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A33CatNome).TrimEnd(' ') )==0)) ? true : false) ;
      }

      protected void InitAll036( )
      {
         K32CatCodi = A32CatCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey036( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void ResetCaption030( )
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
         return "Categoria" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de categorias." ;
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
         return 481 ;
      }

      public override int getFrmHeight( )
      {
         return 169 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TCategoria.htm";
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

      public void execute( int aP0_CatCodigo ,
                           String aP1_Gx_mode )
      {
         this.A32CatCodi = aP0_CatCodigo;
         this.Gx_mode = aP1_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 481 , 169 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtCatCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),143, 61, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 143 , 61 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A32CatCodi" );
         ((GXEdit) edtCatCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtCatCodigo.addFocusListener(this);
         edtCatCodigo.getGXComponent().setHelpId("HLP_TCategoria.htm");
         edtCatNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),143, 87, 273, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 143 , 87 , 273 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A33CatNome" );
         ((GXEdit) edtCatNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtCatNome.addFocusListener(this);
         edtCatNome.getGXComponent().setHelpId("HLP_TCategoria.htm");
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Enter" ,  312 ,  130 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Enter");
         bttBtn_enter.addActionListener(this);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Cadastro de categorias", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 132 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 65 , 40 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 91 , 55 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtCatCodigo ,
                   edtCatNome ,
                   bttBtn_enter
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Catcodigo();
         setFocus(edtCatNome, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey036( ) ;
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setGXEnabled(0);
            edtCatCodigo.setEnabled(0);
            edtCatNome.setEnabled(0);
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
                  InitAll036( ) ;
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
         if ( edtCatCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtCatCodigo.getGXCursor() );
            return;
         }
         if ( edtCatNome.isEventSource(eventSource) ) {
            setGXCursor( edtCatNome.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( edtCatNome.isEventSource(eventSource) ) {
            Valid_Catnome ();
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
         if ( edtCatNome.isEventSource(eventSource) ) {
            A33CatNome = edtCatNome.getValue() ;
            n33CatNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A33CatNome).TrimEnd(' ') )==0)) ? true : false) ;
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
         if ( ( edtCatCodigo.isEventSource(eventSource) ) && ( ( A32CatCodi != edtCatCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
         if ( ( edtCatNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A33CatNome.TrimEnd(' '), edtCatNome.getValue().TrimEnd(' ') ) != 0 ) ) )
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
         ResetCaption030( ) ;
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
         return false;
      }

      public override void deleteLineHandler( Object eventSource ,
                                              int row )
      {
      }

      public override void setNoAccept( Object eventSource )
      {
         if ( edtCatNome.isEventSource(eventSource) )
         {
            edtCatNome.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      public override void VariablesToControls( )
      {
         edtCatCodigo.setValue( A32CatCodi );
         edtCatNome.setValue( A33CatNome );
      }

      public override void ControlsToVariables( )
      {
         A32CatCodi = (int)(edtCatCodigo.getValue()) ;
         edtCatCodigo.setValue(A32CatCodi);
         n32CatCodi = false ;
         A33CatNome = (String)(edtCatNome.getValue()) ;
         edtCatNome.setValue(A33CatNome);
         n33CatNome = false ;
         n33CatNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A33CatNome).TrimEnd(' ') )==0)) ? true : false) ;
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

      protected void Valid_Catcodigo( )
      {
         if ( ( A32CatCodi != K32CatCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K32CatCodi = A32CatCodi ;
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

      protected void Valid_Catnome( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A33CatNome).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "O nome da categoria deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtCatNome );
            setFocusNext();
         }
         reloadGridRow();
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
               sMode6 = Gx_mode ;
               Gx_mode = "UPD" ;
               Gx_mode = sMode6 ;
            }
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               getByPrimaryKey( ) ;
               if ( ( RcdFound6 != 1 ) )
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

      protected void ZM036( int GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z33CatNome = T00033_A33CatNome[0] ;
            }
            else
            {
               Z33CatNome = A33CatNome ;
            }
         }
         if ( ( GX_JID == -2 ) )
         {
            Z32CatCodi = A32CatCodi ;
            Z33CatNome = A33CatNome ;
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

      protected void Load036( )
      {
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {n32CatCodi, A32CatCodi});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound6 = 1 ;
            A33CatNome = T00034_A33CatNome[0] ;
            n33CatNome = T00034_n33CatNome[0] ;
            ZM036( -2) ;
         }
         pr_default.close(2);
         OnLoadActions036( ) ;
      }

      protected void OnLoadActions036( )
      {
      }

      protected void CheckExtendedTable036( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A33CatNome).TrimEnd(' ') )==0)) )
         {
            pushError( "O nome da categoria deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors036( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey036( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {n32CatCodi, A32CatCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1 ;
         }
         else
         {
            RcdFound6 = 0 ;
         }
         pr_default.close(3);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {n32CatCodi, A32CatCodi});
         if ( (pr_default.getStatus(1) != 101) && ( T00033_A32CatCodi[0] == A32CatCodi ) )
         {
            ZM036( 2) ;
            RcdFound6 = 1 ;
            A33CatNome = T00033_A33CatNome[0] ;
            n33CatNome = T00033_n33CatNome[0] ;
            Z32CatCodi = A32CatCodi ;
            sMode6 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load036( ) ;
            Gx_mode = sMode6 ;
         }
         else
         {
            RcdFound6 = 0 ;
            InitializeNonKey036( ) ;
            sMode6 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode6 ;
         }
         K32CatCodi = A32CatCodi ;
         pr_default.close(1);
      }

      public override void getEqualNoModal( )
      {
         GetKey036( ) ;
         if ( ( RcdFound6 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0 ;
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {n32CatCodi, A32CatCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( T00036_A32CatCodi[0] == A32CatCodi ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( T00036_A32CatCodi[0] == A32CatCodi ) )
            {
               RcdFound6 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0 ;
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {n32CatCodi, A32CatCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( T00037_A32CatCodi[0] == A32CatCodi ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( T00037_A32CatCodi[0] == A32CatCodi ) )
            {
               RcdFound6 = 1 ;
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
         GetKey036( ) ;
         if ( ( RcdFound6 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( edtCatCodigo );
            }
            else if ( ( A32CatCodi != Z32CatCodi ) )
            {
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtCatCodigo );
            }
            else
            {
               /* Update record */
               Update036( ) ;
               setNextFocus( edtCatCodigo );
            }
         }
         else
         {
            if ( ( A32CatCodi != Z32CatCodi ) )
            {
               /* Insert record */
               Insert036( ) ;
               setNextFocus( edtCatCodigo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( edtCatCodigo );
               }
               else
               {
                  /* Insert record */
                  Insert036( ) ;
                  setNextFocus( edtCatCodigo );
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
         if ( ( A32CatCodi != Z32CatCodi ) )
         {
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtCatCodigo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( edtCatCodigo );
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

      protected void CheckOptimisticConcurrency036( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {n32CatCodi, A32CatCodi});
            if ( ! (pr_default.getStatus(0) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"CATEGORIA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( String.CompareOrdinal(Z33CatNome.TrimEnd(' '), T00032_A33CatNome[0].TrimEnd(' ') ) != 0 ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"CATEGORIA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert036( )
      {
         BeforeValidate036( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable036( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM036( 0) ;
            CheckOptimisticConcurrency036( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm036( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert036( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T00038 */
                     pr_default.execute(6, new Object[] {n33CatNome, A33CatNome});
                     pr_default.close(6);
                     /* Retrieving last key number assigned */
                     /* Using cursor T00039 */
                     pr_default.execute(7);
                     A32CatCodi = T00039_A32CatCodi[0] ;
                     n32CatCodi = T00039_n32CatCodi[0] ;
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
               Load036( ) ;
            }
            EndLevel036( ) ;
         }
         CloseExtendedTableCursors036( ) ;
      }

      protected void Update036( )
      {
         BeforeValidate036( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable036( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency036( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm036( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate036( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000310 */
                     pr_default.execute(8, new Object[] {n33CatNome, A33CatNome, n32CatCodi, A32CatCodi});
                     pr_default.close(8);
                     DeferredUpdate036( ) ;
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
            EndLevel036( ) ;
         }
         CloseExtendedTableCursors036( ) ;
      }

      protected void DeferredUpdate036( )
      {
      }

      public override void delete( )
      {
         BeforeValidate036( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency036( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls036( ) ;
            /* No cascading delete specified. */
            AfterConfirm036( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete036( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000311 */
                  pr_default.execute(9, new Object[] {n32CatCodi, A32CatCodi});
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
         sMode6 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel036( ) ;
         Gx_mode = sMode6 ;
      }

      protected void OnDeleteControls036( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000312 */
            pr_default.execute(10, new Object[] {n32CatCodi, A32CatCodi});
            if ( (pr_default.getStatus(10) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Dados da mídia locada"}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(10);
            /* Using cursor T000313 */
            pr_default.execute(11, new Object[] {n32CatCodi, A32CatCodi});
            if ( (pr_default.getStatus(11) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de filmes."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(11);
            /* Using cursor T000314 */
            pr_default.execute(12, new Object[] {n32CatCodi, A32CatCodi});
            if ( (pr_default.getStatus(12) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Configurações tipo de mídia."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel036( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(0);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete036( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(1);
            context.CommitDataStores("TCategoria");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("TCategoria");
         }
         IsModified = 0 ;
      }

      protected void ScanStart036( )
      {
         /* Using cursor T000315 */
         pr_default.execute(13, new Object[] {n32CatCodi, A32CatCodi});
         RcdFound6 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound6 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext036( )
      {
         pr_default.readNext(13);
         RcdFound6 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound6 = 1 ;
         }
      }

      protected void ScanEnd036( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm036( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert036( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate036( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete036( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete036( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate036( )
      {
         /* Before Validate Rules */
      }

      protected void CONFIRM_030( )
      {
         BeforeValidate036( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls036( ) ;
            }
            else
            {
               CheckExtendedTable036( ) ;
               CloseExtendedTableCursors036( ) ;
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
         A33CatNome = "" ;
         n33CatNome = false ;
         lastAnyError = 0 ;
         n32CatCodi = false ;
         sMode6 = "" ;
         RcdFound6 = 0 ;
         Z33CatNome = "" ;
         scmdbuf = "" ;
         GX_JID = 0 ;
         Z32CatCodi = 0 ;
         T00034_A32CatCodi = new int[1] ;
         T00034_n32CatCodi = new bool[] {false} ;
         T00034_A33CatNome = new String[] {""} ;
         T00034_n33CatNome = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00035_A32CatCodi = new int[1] ;
         T00035_n32CatCodi = new bool[] {false} ;
         T00033_A32CatCodi = new int[1] ;
         T00033_n32CatCodi = new bool[] {false} ;
         T00033_A33CatNome = new String[] {""} ;
         T00033_n33CatNome = new bool[] {false} ;
         T00036_A32CatCodi = new int[1] ;
         T00036_n32CatCodi = new bool[] {false} ;
         T00037_A32CatCodi = new int[1] ;
         T00037_n32CatCodi = new bool[] {false} ;
         T00032_A32CatCodi = new int[1] ;
         T00032_n32CatCodi = new bool[] {false} ;
         T00032_A33CatNome = new String[] {""} ;
         T00032_n33CatNome = new bool[] {false} ;
         T00039_A32CatCodi = new int[1] ;
         T00039_n32CatCodi = new bool[] {false} ;
         T000312_A86LocCodi = new int[1] ;
         T000312_A102LocMid = new int[1] ;
         T000313_A28FilCodi = new int[1] ;
         T000314_A35MidTipo = new short[1] ;
         T000314_A32CatCodi = new int[1] ;
         T000314_n32CatCodi = new bool[] {false} ;
         T000315_A32CatCodi = new int[1] ;
         T000315_n32CatCodi = new bool[] {false} ;
         K32CatCodi = 0 ;
         n32CatCodi = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tcategoria__default(),
            new Object[][] {
                new Object[] {
               T00032_A32CatCodi, T00032_A33CatNome, T00032_n33CatNome
               }
               , new Object[] {
               T00033_A32CatCodi, T00033_A33CatNome, T00033_n33CatNome
               }
               , new Object[] {
               T00034_A32CatCodi, T00034_A33CatNome, T00034_n33CatNome
               }
               , new Object[] {
               T00035_A32CatCodi
               }
               , new Object[] {
               T00036_A32CatCodi
               }
               , new Object[] {
               T00037_A32CatCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T00039_A32CatCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000312_A86LocCodi, T000312_A102LocMid
               }
               , new Object[] {
               T000313_A28FilCodi
               }
               , new Object[] {
               T000314_A35MidTipo, T000314_A32CatCodi
               }
               , new Object[] {
               T000315_A32CatCodi
               }
            }
         );
         reloadDynamicLists(0);
         K32CatCodi = 0 ;
         edtCatCodigo.setValue(A32CatCodi);
         n32CatCodi = false ;
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short geteqAfterKey= 1 ;
      protected short RcdFound6 ;
      protected short Gx_BScreen ;
      protected int trnEnded ;
      protected int K32CatCodi ;
      protected int A32CatCodi ;
      protected int lastAnyError ;
      protected int GX_JID ;
      protected int Z32CatCodi ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String sMode6 ;
      protected String scmdbuf ;
      protected bool n33CatNome ;
      protected bool n32CatCodi ;
      protected String A33CatNome ;
      protected String Z33CatNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtCatCodigo ;
      protected GUIObjectString edtCatNome ;
      protected IGXButton bttBtn_enter ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl6 ;
      protected IDataReader T00032 ;
      protected IDataReader T00033 ;
      protected IDataReader T00034 ;
      protected IDataStoreProvider pr_default ;
      protected int[] T00034_A32CatCodi ;
      protected bool[] T00034_n32CatCodi ;
      protected String[] T00034_A33CatNome ;
      protected bool[] T00034_n33CatNome ;
      protected IDataReader T00035 ;
      protected int[] T00035_A32CatCodi ;
      protected bool[] T00035_n32CatCodi ;
      protected int[] T00033_A32CatCodi ;
      protected bool[] T00033_n32CatCodi ;
      protected String[] T00033_A33CatNome ;
      protected bool[] T00033_n33CatNome ;
      protected IDataReader T00036 ;
      protected int[] T00036_A32CatCodi ;
      protected bool[] T00036_n32CatCodi ;
      protected IDataReader T00037 ;
      protected int[] T00037_A32CatCodi ;
      protected bool[] T00037_n32CatCodi ;
      protected int[] T00032_A32CatCodi ;
      protected bool[] T00032_n32CatCodi ;
      protected String[] T00032_A33CatNome ;
      protected bool[] T00032_n33CatNome ;
      protected IDataReader T00039 ;
      protected int[] T00039_A32CatCodi ;
      protected bool[] T00039_n32CatCodi ;
      protected IDataReader T000312 ;
      protected int[] T000312_A86LocCodi ;
      protected int[] T000312_A102LocMid ;
      protected IDataReader T000313 ;
      protected int[] T000313_A28FilCodi ;
      protected IDataReader T000314 ;
      protected short[] T000314_A35MidTipo ;
      protected int[] T000314_A32CatCodi ;
      protected bool[] T000314_n32CatCodi ;
      protected IDataReader T000315 ;
      protected int[] T000315_A32CatCodi ;
      protected bool[] T000315_n32CatCodi ;
   }

   public class tcategoria__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@CatNome",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@CatNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000314 ;
          prmT000314 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000315 ;
          prmT000315 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00032", "SELECT [CatCodigo], [CatNome] FROM [CATEGORIA] WITH (UPDLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00033", "SELECT [CatCodigo], [CatNome] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00034", "SELECT TM1.[CatCodigo], TM1.[CatNome] FROM [CATEGORIA] TM1 WITH (NOLOCK) WHERE TM1.[CatCodigo] = @CatCodigo ORDER BY TM1.[CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00035", "SELECT [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00036", "SELECT TOP 1 [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ORDER BY [CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00037", "SELECT TOP 1 [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ORDER BY [CatCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00038", "INSERT INTO [CATEGORIA] ([CatNome]) VALUES (@CatNome)", GxErrorMask.GX_NOMASK,prmT00038)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00039", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT00039,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000310", "UPDATE [CATEGORIA] SET [CatNome]=@CatNome  WHERE [CatCodigo] = @CatCodigo", GxErrorMask.GX_NOMASK,prmT000310)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000311", "DELETE FROM [CATEGORIA]  WHERE [CatCodigo] = @CatCodigo", GxErrorMask.GX_NOMASK,prmT000311)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000312", "SELECT TOP 1 [LocCodigo], [LocMidMidCodigo] FROM [LOCACAOLOCACAOMIDIA] WITH (NOLOCK) WHERE [LocMidCatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000312,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000313", "SELECT TOP 1 [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000313,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000314", "SELECT TOP 1 [MidTipo], [CatCodigo] FROM [CONFTIPMIDIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000314,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000315", "SELECT [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ORDER BY [CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000315,100,0,true,true )
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
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                break;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
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
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
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
