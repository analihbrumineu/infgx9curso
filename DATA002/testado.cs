/*
               File: Estado
        Description: Cadastro de Estados.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 11:31:29.19
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
   public class testado : GXTransaction
   {
      public testado( int hnd ,
                      ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public testado( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public testado( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey047( )
      {
         A25EstUF = "" ;
         n25EstUF = false ;
         n25EstUF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A25EstUF).TrimEnd(' ') )==0)) ? true : false) ;
         A12EstNome = "" ;
         n12EstNome = false ;
         n12EstNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A12EstNome).TrimEnd(' ') )==0)) ? true : false) ;
      }

      protected void InitAll047( )
      {
         K24EstCodi = A24EstCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey047( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void ResetCaption040( )
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
         return "Estado" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de Estados" ;
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
         return 422 ;
      }

      public override int getFrmHeight( )
      {
         return 256 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TEstado.htm";
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

      public void execute( int aP0_EstCodigo ,
                           String aP1_Gx_mode )
      {
         this.A24EstCodi = aP0_EstCodigo;
         this.Gx_mode = aP1_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 422 , 256 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtEstCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),119, 78, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 119 , 78 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A24EstCodi" );
         ((GXEdit) edtEstCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtEstCodigo.addFocusListener(this);
         edtEstCodigo.getGXComponent().setHelpId("HLP_TEstado.htm");
         edtEstUF = new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),119, 105, 26, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.CHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 119 , 105 , 26 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A25EstUF" );
         ((GXEdit) edtEstUF.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstUF.addFocusListener(this);
         edtEstUF.getGXComponent().setHelpId("HLP_TEstado.htm");
         edtEstNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),119, 131, 226, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 119 , 131 , 226 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A12EstNome" );
         ((GXEdit) edtEstNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstNome.addFocusListener(this);
         edtEstNome.getGXComponent().setHelpId("HLP_TEstado.htm");
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Enter" ,  256 ,  182 ,  89 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Enter");
         bttBtn_enter.addActionListener(this);
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 63 , 82 , 40 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 86 , 108 , 17 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 63 , 133 , 40 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtEstCodigo ,
                   edtEstUF ,
                   edtEstNome ,
                   bttBtn_enter
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Estcodigo();
         setFocus(edtEstUF, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey047( ) ;
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setGXEnabled(0);
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
                  InitAll047( ) ;
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
         if ( edtEstUF.isEventSource(eventSource) ) {
            Valid_Estuf ();
            return;
         }
         if ( edtEstNome.isEventSource(eventSource) ) {
            Valid_Estnome ();
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            Valid_Estcodigo ();
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            A24EstCodi = edtEstCodigo.getValue() ;
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            A25EstUF = edtEstUF.getValue() ;
            n25EstUF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A25EstUF).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtEstNome.isEventSource(eventSource) ) {
            A12EstNome = edtEstNome.getValue() ;
            n12EstNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A12EstNome).TrimEnd(' ') )==0)) ? true : false) ;
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
         if ( ( edtEstCodigo.isEventSource(eventSource) ) && ( ( A24EstCodi != edtEstCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
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
         ResetCaption040( ) ;
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
         if ( edtEstUF.isEventSource(eventSource) )
         {
            edtEstUF.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtEstNome.isEventSource(eventSource) )
         {
            edtEstNome.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      public override void VariablesToControls( )
      {
         edtEstCodigo.setValue( A24EstCodi );
         edtEstUF.setValue( A25EstUF );
         edtEstNome.setValue( A12EstNome );
      }

      public override void ControlsToVariables( )
      {
         A24EstCodi = (int)(edtEstCodigo.getValue()) ;
         edtEstCodigo.setValue(A24EstCodi);
         n24EstCodi = false ;
         A25EstUF = (String)(edtEstUF.getValue()) ;
         edtEstUF.setValue(A25EstUF);
         n25EstUF = false ;
         n25EstUF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A25EstUF).TrimEnd(' ') )==0)) ? true : false) ;
         A12EstNome = (String)(edtEstNome.getValue()) ;
         edtEstNome.setValue(A12EstNome);
         n12EstNome = false ;
         n12EstNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A12EstNome).TrimEnd(' ') )==0)) ? true : false) ;
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

      protected void Valid_Estcodigo( )
      {
         if ( ( A24EstCodi != K24EstCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K24EstCodi = A24EstCodi ;
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

      protected void Valid_Estuf( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A25EstUF).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "UF deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtEstUF );
            setFocusNext();
         }
      }

      protected void Valid_Estnome( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A12EstNome).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Nome do Estado deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtEstNome );
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
               sMode7 = Gx_mode ;
               Gx_mode = "UPD" ;
               Gx_mode = sMode7 ;
            }
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               getByPrimaryKey( ) ;
               if ( ( RcdFound7 != 1 ) )
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

      protected void ZM047( int GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z25EstUF = T00043_A25EstUF[0] ;
               Z12EstNome = T00043_A12EstNome[0] ;
            }
            else
            {
               Z25EstUF = A25EstUF ;
               Z12EstNome = A12EstNome ;
            }
         }
         if ( ( GX_JID == -3 ) )
         {
            Z24EstCodi = A24EstCodi ;
            Z25EstUF = A25EstUF ;
            Z12EstNome = A12EstNome ;
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

      protected void Load047( )
      {
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound7 = 1 ;
            A25EstUF = T00044_A25EstUF[0] ;
            n25EstUF = T00044_n25EstUF[0] ;
            A12EstNome = T00044_A12EstNome[0] ;
            n12EstNome = T00044_n12EstNome[0] ;
            ZM047( -3) ;
         }
         pr_default.close(2);
         OnLoadActions047( ) ;
      }

      protected void OnLoadActions047( )
      {
      }

      protected void CheckExtendedTable047( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A25EstUF).TrimEnd(' ') )==0)) )
         {
            pushError( "UF deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A12EstNome).TrimEnd(' ') )==0)) )
         {
            pushError( "Nome do Estado deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors047( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey047( )
      {
         /* Using cursor T00045 */
         pr_default.execute(3, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound7 = 1 ;
         }
         else
         {
            RcdFound7 = 0 ;
         }
         pr_default.close(3);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(1) != 101) && ( T00043_A24EstCodi[0] == A24EstCodi ) )
         {
            ZM047( 3) ;
            RcdFound7 = 1 ;
            A25EstUF = T00043_A25EstUF[0] ;
            n25EstUF = T00043_n25EstUF[0] ;
            A12EstNome = T00043_A12EstNome[0] ;
            n12EstNome = T00043_n12EstNome[0] ;
            Z24EstCodi = A24EstCodi ;
            sMode7 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load047( ) ;
            Gx_mode = sMode7 ;
         }
         else
         {
            RcdFound7 = 0 ;
            InitializeNonKey047( ) ;
            sMode7 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode7 ;
         }
         K24EstCodi = A24EstCodi ;
         pr_default.close(1);
      }

      public override void getEqualNoModal( )
      {
         GetKey047( ) ;
         if ( ( RcdFound7 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound7 = 0 ;
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( T00046_A24EstCodi[0] == A24EstCodi ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( T00046_A24EstCodi[0] == A24EstCodi ) )
            {
               RcdFound7 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0 ;
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( T00047_A24EstCodi[0] == A24EstCodi ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( T00047_A24EstCodi[0] == A24EstCodi ) )
            {
               RcdFound7 = 1 ;
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
         GetKey047( ) ;
         if ( ( RcdFound7 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( edtEstCodigo );
            }
            else if ( ( A24EstCodi != Z24EstCodi ) )
            {
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtEstCodigo );
            }
            else
            {
               /* Update record */
               Update047( ) ;
               setNextFocus( edtEstCodigo );
            }
         }
         else
         {
            if ( ( A24EstCodi != Z24EstCodi ) )
            {
               /* Insert record */
               Insert047( ) ;
               setNextFocus( edtEstCodigo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( edtEstCodigo );
               }
               else
               {
                  /* Insert record */
                  Insert047( ) ;
                  setNextFocus( edtEstCodigo );
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
         if ( ( A24EstCodi != Z24EstCodi ) )
         {
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtEstCodigo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( edtEstCodigo );
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

      protected void CheckOptimisticConcurrency047( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {n24EstCodi, A24EstCodi});
            if ( ! (pr_default.getStatus(0) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"ESTADO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( String.CompareOrdinal(Z25EstUF.TrimEnd(' '), T00042_A25EstUF[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z12EstNome.TrimEnd(' '), T00042_A12EstNome[0].TrimEnd(' ') ) != 0 ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"ESTADO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert047( )
      {
         BeforeValidate047( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable047( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM047( 0) ;
            CheckOptimisticConcurrency047( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm047( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert047( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T00048 */
                     pr_default.execute(6, new Object[] {n25EstUF, A25EstUF, n12EstNome, A12EstNome});
                     pr_default.close(6);
                     /* Retrieving last key number assigned */
                     /* Using cursor T00049 */
                     pr_default.execute(7);
                     A24EstCodi = T00049_A24EstCodi[0] ;
                     n24EstCodi = T00049_n24EstCodi[0] ;
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
               Load047( ) ;
            }
            EndLevel047( ) ;
         }
         CloseExtendedTableCursors047( ) ;
      }

      protected void Update047( )
      {
         BeforeValidate047( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable047( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency047( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm047( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate047( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000410 */
                     pr_default.execute(8, new Object[] {n25EstUF, A25EstUF, n12EstNome, A12EstNome, n24EstCodi, A24EstCodi});
                     pr_default.close(8);
                     DeferredUpdate047( ) ;
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
            EndLevel047( ) ;
         }
         CloseExtendedTableCursors047( ) ;
      }

      protected void DeferredUpdate047( )
      {
      }

      public override void delete( )
      {
         BeforeValidate047( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency047( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls047( ) ;
            /* No cascading delete specified. */
            AfterConfirm047( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete047( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000411 */
                  pr_default.execute(9, new Object[] {n24EstCodi, A24EstCodi});
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
         sMode7 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel047( ) ;
         Gx_mode = sMode7 ;
      }

      protected void OnDeleteControls047( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000412 */
            pr_default.execute(10, new Object[] {n24EstCodi, A24EstCodi});
            if ( (pr_default.getStatus(10) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de cidades."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel047( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(0);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete047( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(1);
            context.CommitDataStores("TEstado");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("TEstado");
         }
         IsModified = 0 ;
      }

      protected void ScanStart047( )
      {
         /* Using cursor T000413 */
         pr_default.execute(11, new Object[] {n24EstCodi, A24EstCodi});
         RcdFound7 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound7 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext047( )
      {
         pr_default.readNext(11);
         RcdFound7 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound7 = 1 ;
         }
      }

      protected void ScanEnd047( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm047( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert047( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate047( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete047( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete047( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate047( )
      {
         /* Before Validate Rules */
      }

      protected void CONFIRM_040( )
      {
         BeforeValidate047( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls047( ) ;
            }
            else
            {
               CheckExtendedTable047( ) ;
               CloseExtendedTableCursors047( ) ;
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
         A25EstUF = "" ;
         n25EstUF = false ;
         A12EstNome = "" ;
         n12EstNome = false ;
         lastAnyError = 0 ;
         n24EstCodi = false ;
         sMode7 = "" ;
         RcdFound7 = 0 ;
         Z25EstUF = "" ;
         Z12EstNome = "" ;
         scmdbuf = "" ;
         GX_JID = 0 ;
         Z24EstCodi = 0 ;
         T00044_A24EstCodi = new int[1] ;
         T00044_n24EstCodi = new bool[] {false} ;
         T00044_A25EstUF = new String[] {""} ;
         T00044_n25EstUF = new bool[] {false} ;
         T00044_A12EstNome = new String[] {""} ;
         T00044_n12EstNome = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00045_A24EstCodi = new int[1] ;
         T00045_n24EstCodi = new bool[] {false} ;
         T00043_A24EstCodi = new int[1] ;
         T00043_n24EstCodi = new bool[] {false} ;
         T00043_A25EstUF = new String[] {""} ;
         T00043_n25EstUF = new bool[] {false} ;
         T00043_A12EstNome = new String[] {""} ;
         T00043_n12EstNome = new bool[] {false} ;
         T00046_A24EstCodi = new int[1] ;
         T00046_n24EstCodi = new bool[] {false} ;
         T00047_A24EstCodi = new int[1] ;
         T00047_n24EstCodi = new bool[] {false} ;
         T00042_A24EstCodi = new int[1] ;
         T00042_n24EstCodi = new bool[] {false} ;
         T00042_A25EstUF = new String[] {""} ;
         T00042_n25EstUF = new bool[] {false} ;
         T00042_A12EstNome = new String[] {""} ;
         T00042_n12EstNome = new bool[] {false} ;
         T00049_A24EstCodi = new int[1] ;
         T00049_n24EstCodi = new bool[] {false} ;
         T000412_A26CidCodi = new int[1] ;
         T000413_A24EstCodi = new int[1] ;
         T000413_n24EstCodi = new bool[] {false} ;
         K24EstCodi = 0 ;
         n24EstCodi = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.testado__default(),
            new Object[][] {
                new Object[] {
               T00042_A24EstCodi, T00042_A25EstUF, T00042_n25EstUF, T00042_A12EstNome, T00042_n12EstNome
               }
               , new Object[] {
               T00043_A24EstCodi, T00043_A25EstUF, T00043_n25EstUF, T00043_A12EstNome, T00043_n12EstNome
               }
               , new Object[] {
               T00044_A24EstCodi, T00044_A25EstUF, T00044_n25EstUF, T00044_A12EstNome, T00044_n12EstNome
               }
               , new Object[] {
               T00045_A24EstCodi
               }
               , new Object[] {
               T00046_A24EstCodi
               }
               , new Object[] {
               T00047_A24EstCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T00049_A24EstCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000412_A26CidCodi
               }
               , new Object[] {
               T000413_A24EstCodi
               }
            }
         );
         reloadDynamicLists(0);
         K24EstCodi = 0 ;
         edtEstCodigo.setValue(A24EstCodi);
         n24EstCodi = false ;
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short geteqAfterKey= 1 ;
      protected short RcdFound7 ;
      protected short Gx_BScreen ;
      protected int trnEnded ;
      protected int K24EstCodi ;
      protected int A24EstCodi ;
      protected int lastAnyError ;
      protected int GX_JID ;
      protected int Z24EstCodi ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String A25EstUF ;
      protected String sMode7 ;
      protected String Z25EstUF ;
      protected String scmdbuf ;
      protected bool n25EstUF ;
      protected bool n12EstNome ;
      protected bool n24EstCodi ;
      protected String A12EstNome ;
      protected String Z12EstNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtEstCodigo ;
      protected GUIObjectString edtEstUF ;
      protected GUIObjectString edtEstNome ;
      protected IGXButton bttBtn_enter ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl8 ;
      protected IDataReader T00042 ;
      protected IDataReader T00043 ;
      protected IDataReader T00044 ;
      protected IDataStoreProvider pr_default ;
      protected int[] T00044_A24EstCodi ;
      protected bool[] T00044_n24EstCodi ;
      protected String[] T00044_A25EstUF ;
      protected bool[] T00044_n25EstUF ;
      protected String[] T00044_A12EstNome ;
      protected bool[] T00044_n12EstNome ;
      protected IDataReader T00045 ;
      protected int[] T00045_A24EstCodi ;
      protected bool[] T00045_n24EstCodi ;
      protected int[] T00043_A24EstCodi ;
      protected bool[] T00043_n24EstCodi ;
      protected String[] T00043_A25EstUF ;
      protected bool[] T00043_n25EstUF ;
      protected String[] T00043_A12EstNome ;
      protected bool[] T00043_n12EstNome ;
      protected IDataReader T00046 ;
      protected int[] T00046_A24EstCodi ;
      protected bool[] T00046_n24EstCodi ;
      protected IDataReader T00047 ;
      protected int[] T00047_A24EstCodi ;
      protected bool[] T00047_n24EstCodi ;
      protected int[] T00042_A24EstCodi ;
      protected bool[] T00042_n24EstCodi ;
      protected String[] T00042_A25EstUF ;
      protected bool[] T00042_n25EstUF ;
      protected String[] T00042_A12EstNome ;
      protected bool[] T00042_n12EstNome ;
      protected IDataReader T00049 ;
      protected int[] T00049_A24EstCodi ;
      protected bool[] T00049_n24EstCodi ;
      protected IDataReader T000412 ;
      protected int[] T000412_A26CidCodi ;
      protected IDataReader T000413 ;
      protected int[] T000413_A24EstCodi ;
      protected bool[] T000413_n24EstCodi ;
   }

   public class testado__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@EstUF",SqlDbType.Char,2,0} ,
          new Object[] {"@EstNome",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@EstUF",SqlDbType.Char,2,0} ,
          new Object[] {"@EstNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00042", "SELECT [EstCodigo], [EstUF], [EstNome] FROM [ESTADO] WITH (UPDLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00043", "SELECT [EstCodigo], [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00044", "SELECT TM1.[EstCodigo], TM1.[EstUF], TM1.[EstNome] FROM [ESTADO] TM1 WITH (NOLOCK) WHERE TM1.[EstCodigo] = @EstCodigo ORDER BY TM1.[EstCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00045", "SELECT [EstCodigo] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00046", "SELECT TOP 1 [EstCodigo] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ORDER BY [EstCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00047", "SELECT TOP 1 [EstCodigo] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ORDER BY [EstCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00048", "INSERT INTO [ESTADO] ([EstUF], [EstNome]) VALUES (@EstUF, @EstNome)", GxErrorMask.GX_NOMASK,prmT00048)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00049", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000410", "UPDATE [ESTADO] SET [EstUF]=@EstUF, [EstNome]=@EstNome  WHERE [EstCodigo] = @EstCodigo", GxErrorMask.GX_NOMASK,prmT000410)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000411", "DELETE FROM [ESTADO]  WHERE [EstCodigo] = @EstCodigo", GxErrorMask.GX_NOMASK,prmT000411)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000412", "SELECT TOP 1 [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000412,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000413", "SELECT [EstCodigo] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ORDER BY [EstCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000413,100,0,true,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
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
                break;
             case 11 :
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
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
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
       }
    }

 }

}
