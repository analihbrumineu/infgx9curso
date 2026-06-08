/*
               File: PeCidade
        Description: Cadastro de cidades
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/3/2026 10:48:12.78
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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class wpecidade : GXWorkpanel
   {
      public wpecidade( int hnd ,
                        ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpecidade( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpecidade( IGxContext context ,
                        int hnd ,
                        ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeCidade" ;
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
         return 780 ;
      }

      public override int getFrmHeight( )
      {
         return 780 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeCidade.htm";
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
         GXV_ESTUF_htmlV0B2( ) ;
      }

      public void runLoad_load02( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwpecidade02 = new subwpecidade02 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV7CidNome ,
                                              AV9EstUF ,
                                              AV8CidCodi ,
                                              A27CidNome ,
                                              A25EstUF ,
                                              A26CidCodi },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         /* Using cursor W000B2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf2.getSize() < 10000 ) ) )
         {
            A24EstCodi = W000B2_A24EstCodi[0] ;
            n24EstCodi = W000B2_n24EstCodi[0] ;
            A27CidNome = W000B2_A27CidNome[0] ;
            n27CidNome = W000B2_n27CidNome[0] ;
            A26CidCodi = W000B2_A26CidCodi[0] ;
            A25EstUF = W000B2_A25EstUF[0] ;
            n25EstUF = W000B2_n25EstUF[0] ;
            A25EstUF = W000B2_A25EstUF[0] ;
            n25EstUF = W000B2_n25EstUF[0] ;
            /* Execute user event: E11V0B2 */
            E11V0B2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf2.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeCidade_load02 : GXLoadProducer
      {
         wpecidade _sf ;

         public PeCidade_load02( wpecidade uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer02();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load02();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors02();
         }

      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         if ( ! gxIsRefreshing )
         {
            gxIsRefreshing = true ;
            ControlsToVariables();
            standAlone();
            VariablesToControls();
            subGxsf2.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow02( )
      {
         return true;
      }

      public void autoRefresh_flow02( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow02() )) {
            subfile.refresh();
            resetSubfileConditions_flow02() ;
         }
      }

      public bool getSearch_flow02( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow02( )
      {
      }

      public void resetSearchConditions_flow02( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow02( )
      {
         return new subwpecidade02 ();
      }

      public bool getSearch_flow02( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow02( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow02( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow02( )
      {
         GXRefreshCommand02 ();
      }

      public class PeCidade_flow02 : GXSubfileFlow
      {
         wpecidade _sf ;

         public PeCidade_flow02( wpecidade uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow02();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow02(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow02();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow02();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow02(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow02();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow02(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow02(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow02(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow02();
         }

      }

      protected void GXRefreshCommand02( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public void loadToBuffer02( )
      {
         subwpecidade02 oAux = subwpecidade02 ;
         subwpecidade02 = new subwpecidade02 ();
         variablesToSubfile02 ();
         subGxsf2.addElement(subwpecidade02);
         subwpecidade02 = oAux;
      }

      private void E11V0B2( )
      {
         /* Load Routine */
         AV6Excluir = "c:\\KB\\DATA002\\bin\\deleteIcon.jpg" ;
         AV5Editar = "c:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         AV10Visual = "c:\\KB\\DATA002\\bin\\visualizarIcon.jpg" ;
         subGxsf2.loadCommand();
      }

      protected void closeCursors02( )
      {
         pr_default.close(0);
      }

      protected void E12V0B2( )
      {
         eventLevelContext();
         /* Visualizar_Click Routine */
         new tcidade(context, base.remoteHandle, base.context).execute(  A26CidCodi,  "DSP") ;
         eventLevelResetContext();
      }

      protected void E13V0B2( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         new tcidade(context, base.remoteHandle, base.context).execute(  A26CidCodi,  "UPD") ;
         GXRefresh();
      }

      protected void E14V0B2( )
      {
         eventLevelContext();
         /* Excluir_Click Routine */
         new tcidade(context, base.remoteHandle, base.context).execute(  A26CidCodi,  "DLT") ;
         GXRefresh();
      }

      protected void E15V0B2( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tcidade(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 780 , 780 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCidcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 78, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 78 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8CidCodi" );
         ((GXEdit) edtavCidcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCidcodigo.addFocusListener(this);
         edtavCidcodigo.getGXComponent().setHelpId("HLP_WPeCidade.htm");
         edtavCidnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),156, 78, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 78 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7CidNome" );
         ((GXEdit) edtavCidnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCidnome.addFocusListener(this);
         edtavCidnome.getGXComponent().setHelpId("HLP_WPeCidade.htm");
         dynavEstuf = new GUIObjectString ( new GXComboBox(GXPanel1, this, 15) , GXPanel1 , 533 , 78 , 40 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9EstUF" );
         dynavEstuf.addFocusListener(this);
         dynavEstuf.addItemListener(this);
         dynavEstuf.getGXComponent().setHelpId("HLP_WPeCidade.htm");
         addSubfile ( subGxsf2  = new GXSubfile ( new PeCidade_load02(this), new PeCidade_flow02(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV10Visual" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV5Editar" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV6Excluir" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),0, 0, 55, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.CHAR, false, false, 0, false) , null ,  0 , 0 , 54 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A25EstUF" ), "UF"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 54 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 79, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 78 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A26CidCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 78 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 381, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 380 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A27CidNome" ), "Cidade"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 380 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 35 , 18 , GXPanel1 , 65 , 117 , 651 , 650 ,  18 ));
         subGxsf2.addActionListener(this);
         subGxsf2.addFocusListener(this);
         subGxsf2.setSortOnClick(true);
         subGxsf2.addItemListener(this);
         subGxsf2.getColumn(0).addActionListener( this);
         subGxsf2.getColumn(0).addItemListener( this);
         subGxsf2.getColumn(1).addActionListener( this);
         subGxsf2.getColumn(1).addItemListener( this);
         subGxsf2.getColumn(2).addActionListener( this);
         subGxsf2.getColumn(2).addItemListener( this);
         bttbtt12 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  585 ,  78 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt12.setTooltip("Novo");
         bttbtt12.addActionListener(this);
         bttbtt12.setFiresEvents(false);
         lbllbl16 = UIFactory.getLabel(GXPanel1, "Cadastro de cidades", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 117 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 65 , 40 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 156 , 65 , 40 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 533 , 65 , 17 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCidcodigo ,
                   edtavCidnome ,
                   dynavEstuf ,
                   subGxsf2 ,
                   bttbtt12
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf2, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile02( )
      {
         subwpecidade02.setVVisualizar(AV10Visual);
         subwpecidade02.setVEditar(AV5Editar);
         subwpecidade02.setVExcluir(AV6Excluir);
         subwpecidade02.setEstUF(A25EstUF);
         subwpecidade02.setCidCodigo(A26CidCodi);
         subwpecidade02.setCidNome(A27CidNome);
      }

      protected void subfileToVariables02( )
      {
         AV10Visual = subwpecidade02.getVVisualizar();
         AV5Editar = subwpecidade02.getVEditar();
         AV6Excluir = subwpecidade02.getVExcluir();
         A25EstUF = subwpecidade02.getEstUF();
         A26CidCodi = subwpecidade02.getCidCodigo();
         A27CidNome = subwpecidade02.getCidNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCidcodigo.setValue( AV8CidCodi );
         edtavCidnome.setValue( AV7CidNome );
         dynavEstuf.setValue( AV9EstUF );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV8CidCodi = (int)(edtavCidcodigo.getValue()) ;
         edtavCidcodigo.setValue(AV8CidCodi);
         AV7CidNome = (String)(edtavCidnome.getValue()) ;
         edtavCidnome.setValue(AV7CidNome);
         AV9EstUF = (String)(dynavEstuf.getValue()) ;
         dynavEstuf.setValue(AV9EstUF);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf2.inValidElement() )
         {
            subwpecidade02 = ( subwpecidade02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpecidade02 = new subwpecidade02 ();
         }
         subfileToVariables02 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile02 ();
         subGxsf2.refreshLineValue(subwpecidade02);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf2.inValidElement() )
         {
            subwpecidade02 = ( subwpecidade02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpecidade02 = new subwpecidade02 ();
         }
         subfileToVariables02 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt12.isEventSource(eventSource) ) {
            /* Execute user event: E15V0B2 */
            E15V0B2 ();
            return;
         }
         if ( subGxsf2.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E12V0B2 */
            E12V0B2 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E13V0B2 */
            E13V0B2 ();
            return;
         }
         if ( subGxsf2.getColumn(2).isEventSource(eventSource) ) {
            /* Execute user event: E14V0B2 */
            E14V0B2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCidcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCidcodigo.getGXCursor() );
            return;
         }
         if ( edtavCidnome.isEventSource(eventSource) ) {
            setGXCursor( edtavCidnome.getGXCursor() );
            return;
         }
         if ( dynavEstuf.isEventSource(eventSource) ) {
            setGXCursor( dynavEstuf.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            GXV_ESTUF_htmlV0B2( ) ;
            VariablesToControls();
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavCidcodigo.isEventSource(eventSource) ) {
            AV8CidCodi = edtavCidcodigo.getValue() ;
            return;
         }
         if ( edtavCidnome.isEventSource(eventSource) ) {
            AV7CidNome = edtavCidnome.getValue() ;
            return;
         }
         if ( dynavEstuf.isEventSource(eventSource) ) {
            AV9EstUF = dynavEstuf.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E12V0B2 */
            E12V0B2 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V0B2 */
            E13V0B2 ();
            return;
         }
         if ( subGxsf2.getColumn(2).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0B2 */
            E14V0B2 ();
            return;
         }
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

      protected void GXV_ESTUF_htmlV0B2( )
      {
         String gxdynajaxvalue ;
         GXDLV_ESTUF_dataV0B2( ) ;
         gxdynajaxindex = 1 ;
         while ( ( gxdynajaxindex <= gxdynajaxctrlcodr.Count ) )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            ((GXComboBox) dynavEstuf.getGXComponent()).addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), (short)(gxdynajaxindex));
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         ((GXComboBox) dynavEstuf.getGXComponent()).removeAllItemsFrom(gxdynajaxindex);
      }

      protected void GXDLV_ESTUF_dataV0B2( )
      {
         /* Using cursor W000B3 */
         pr_default.execute(1);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("UF");
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( W000B3_A25EstUF[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( W000B3_A25EstUF[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
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
         subwpecidade02 = new subwpecidade02();
         scmdbuf = "" ;
         AV7CidNome = "" ;
         AV9EstUF = "" ;
         AV8CidCodi = 0 ;
         A27CidNome = "" ;
         A25EstUF = "" ;
         A26CidCodi = 0 ;
         W000B2_A24EstCodi = new int[1] ;
         W000B2_n24EstCodi = new bool[] {false} ;
         W000B2_A27CidNome = new String[] {""} ;
         W000B2_n27CidNome = new bool[] {false} ;
         W000B2_A26CidCodi = new int[1] ;
         W000B2_A25EstUF = new String[] {""} ;
         W000B2_n25EstUF = new bool[] {false} ;
         A24EstCodi = 0 ;
         n24EstCodi = false ;
         n27CidNome = false ;
         n25EstUF = false ;
         gxIsRefreshing = false ;
         AV6Excluir = "" ;
         AV5Editar = "" ;
         AV10Visual = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxindex = 0 ;
         W000B3_A24EstCodi = new int[1] ;
         W000B3_n24EstCodi = new bool[] {false} ;
         W000B3_A25EstUF = new String[] {""} ;
         W000B3_n25EstUF = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpecidade__default(),
            new Object[][] {
                new Object[] {
               W000B2_A24EstCodi, W000B2_n24EstCodi, W000B2_A27CidNome, W000B2_n27CidNome, W000B2_A26CidCodi, W000B2_A25EstUF, W000B2_n25EstUF
               }
               , new Object[] {
               W000B3_A24EstCodi, W000B3_A25EstUF, W000B3_n25EstUF
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV8CidCodi ;
      protected int A26CidCodi ;
      protected int A24EstCodi ;
      protected int gxdynajaxindex ;
      protected String scmdbuf ;
      protected String AV9EstUF ;
      protected String A25EstUF ;
      protected bool n24EstCodi ;
      protected bool n27CidNome ;
      protected bool n25EstUF ;
      protected bool gxIsRefreshing ;
      protected String AV7CidNome ;
      protected String A27CidNome ;
      protected String AV6Excluir ;
      protected String AV5Editar ;
      protected String AV10Visual ;
      protected GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      protected GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpecidade02 subwpecidade02 ;
      protected IDataReader W000B2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W000B2_A24EstCodi ;
      protected bool[] W000B2_n24EstCodi ;
      protected String[] W000B2_A27CidNome ;
      protected bool[] W000B2_n27CidNome ;
      protected int[] W000B2_A26CidCodi ;
      protected String[] W000B2_A25EstUF ;
      protected bool[] W000B2_n25EstUF ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCidcodigo ;
      protected GUIObjectString edtavCidnome ;
      protected GUIObjectString dynavEstuf ;
      protected GXSubfile subGxsf2 ;
      protected IGXButton bttbtt12 ;
      protected ILabel lbllbl16 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl10 ;
      protected IDataReader W000B3 ;
      protected int[] W000B3_A24EstCodi ;
      protected bool[] W000B3_n24EstCodi ;
      protected String[] W000B3_A25EstUF ;
      protected bool[] W000B3_n25EstUF ;
   }

   public class wpecidade__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000B2( String AV7CidNome ,
                                           String AV9EstUF ,
                                           int AV8CidCodi ,
                                           String A27CidNome ,
                                           String A25EstUF ,
                                           int A26CidCodi )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T1.[EstCodigo], T1.[CidNome], T1.[CidCodigo], T2.[EstUF] FROM ([CIDADE] T1 WITH (NOLOCK) LEFT JOIN [ESTADO] T2 WITH (NOLOCK) ON T2.[EstCodigo] = T1.[EstCodigo])" ;
         sWhereString = "" ;
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV7CidNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[CidNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7CidNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[CidNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7CidNome, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV9EstUF).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T2.[EstUF] = '" + StringUtil.RTrim( StringUtil.StringReplace( AV9EstUF, "'", "''")) + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T2.[EstUF] = '" + StringUtil.RTrim( StringUtil.StringReplace( AV9EstUF, "'", "''")) + "')" ;
            }
         }
         if ( ! ((0==AV8CidCodi)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[CidCodigo] = " + StringUtil.Str( (decimal)(AV8CidCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[CidCodigo] = " + StringUtil.Str( (decimal)(AV8CidCodi), 9, 0) + ")" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[CidCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000B2( (String)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (int)dynConstraints[5] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW000B3 ;
          prmW000B3 = new Object[] {
          } ;
          Object[] prmW000B2 ;
          prmW000B2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000B2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000B2,28,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000B3", "SELECT [EstCodigo], [EstUF] FROM [ESTADO] WITH (NOLOCK) ORDER BY [EstUF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000B3,0,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((int[]) buf[4])[0] = rslt.getInt(3) ;
                ((String[]) buf[5])[0] = rslt.getString(4, 2) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
