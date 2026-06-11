/*
               File: Gx0090
        Description: Lista de Seleção Cadastro de mídias.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:24.37
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
   public class wgx0090 : GXWorkpanel
   {
      public wgx0090( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx0090( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx0090( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx0090" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Cadastro de mídias." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return ApplicationUI.getDefaultMenuBar(this) ;
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
         return 603 ;
      }

      public override int getFrmHeight( )
      {
         return 354 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx0090.htm";
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

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( out int aP0_pMidCodigo )
      {
         this.AV10pMidCo = 0 ;
         executePrivate();
         aP0_pMidCodigo=this.AV10pMidCo;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load16( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwgx009016 = new subwgx009016 ();
         /* Using cursor W002K2 */
         pr_default.execute(0, new Object[] {AV5cMidCod, AV6cMidTip, AV7cMidSit, AV8cFilCod, AV9cLocCod});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A116LocCod = W002K2_A116LocCod[0] ;
            n116LocCod = W002K2_n116LocCod[0] ;
            A28FilCodi = W002K2_A28FilCodi[0] ;
            n28FilCodi = W002K2_n28FilCodi[0] ;
            A36MidSitu = W002K2_A36MidSitu[0] ;
            n36MidSitu = W002K2_n36MidSitu[0] ;
            A35MidTipo = W002K2_A35MidTipo[0] ;
            n35MidTipo = W002K2_n35MidTipo[0] ;
            A37MidCodi = W002K2_A37MidCodi[0] ;
            /* Execute user event: E11V2K2 */
            E11V2K2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx0090_load16 : GXLoadProducer
      {
         wgx0090 _sf ;

         public Gx0090_load16( wgx0090 uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer16();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load16();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors16();
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
            subGrd_1.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow16( )
      {
         return true;
      }

      public void autoRefresh_flow16( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV5cMidCod!=cV5cMidCod)||(AV6cMidTip!=cV6cMidTip)||(AV7cMidSit!=cV7cMidSit)||(AV8cFilCod!=cV8cFilCod)||(AV9cLocCod!=cV9cLocCod) ) || (!loadedFirstTime && ! isLoadAtStartup_flow16() )) {
            subfile.refresh();
            resetSubfileConditions_flow16() ;
         }
      }

      public bool getSearch_flow16( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow16( )
      {
         cV5cMidCod = AV5cMidCod ;
         cV6cMidTip = AV6cMidTip ;
         cV7cMidSit = AV7cMidSit ;
         cV8cFilCod = AV8cFilCod ;
         cV9cLocCod = AV9cLocCod ;
      }

      public void resetSearchConditions_flow16( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow16( )
      {
         return new subwgx009016 ();
      }

      public bool getSearch_flow16( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow16( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow16( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow16( )
      {
         GXRefreshCommand16 ();
      }

      public class Gx0090_flow16 : GXSubfileFlow
      {
         wgx0090 _sf ;

         public Gx0090_flow16( wgx0090 uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow16();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow16(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow16();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow16();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow16(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow16();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow16(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow16(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow16(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow16();
         }

      }

      protected void GXRefreshCommand16( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXEnter( )
      {
         /* Execute user event: E12V2K2 */
         E12V2K2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2K2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV10pMidCo = A37MidCodi ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer16( )
      {
         subwgx009016 oAux = subwgx009016 ;
         subwgx009016 = new subwgx009016 ();
         variablesToSubfile16 ();
         subGrd_1.addElement(subwgx009016);
         subwgx009016 = oAux;
      }

      private void E11V2K2( )
      {
         /* Load Routine */
         subGrd_1.loadCommand();
      }

      protected void closeCursors16( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 0 , 0 , 603 , 354 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCmidcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),154, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 154 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cMidCod" );
         ((GXEdit) edtavCmidcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCmidcodigo.addFocusListener(this);
         edtavCmidcodigo.getGXComponent().setHelpId("HLP_WGx0090.htm");
         cmbavCmidtipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 154 , 48 , 68 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cMidTip" );
         ((GXComboBox) cmbavCmidtipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbavCmidtipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbavCmidtipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) cmbavCmidtipo.getGXComponent()).addItem( new java.lang.Short(4),"Box");
         cmbavCmidtipo.addFocusListener(this);
         cmbavCmidtipo.addItemListener(this);
         cmbavCmidtipo.getGXComponent().setHelpId("HLP_WGx0090.htm");
         cmbavCmidsituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 154 , 72 , 82 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7cMidSit" );
         ((GXComboBox) cmbavCmidsituacao.getGXComponent()).addItem( new java.lang.Short(1),"Liberado");
         ((GXComboBox) cmbavCmidsituacao.getGXComponent()).addItem( new java.lang.Short(2),"Locado");
         cmbavCmidsituacao.addFocusListener(this);
         cmbavCmidsituacao.addItemListener(this);
         cmbavCmidsituacao.getGXComponent().setHelpId("HLP_WGx0090.htm");
         edtavCfilcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),154, 96, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 154 , 96 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8cFilCod" );
         ((GXEdit) edtavCfilcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCfilcodigo.addFocusListener(this);
         edtavCfilcodigo.getGXComponent().setHelpId("HLP_WGx0090.htm");
         edtavCloccodloccodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),154, 120, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 154 , 120 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9cLocCod" );
         ((GXEdit) edtavCloccodloccodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCloccodloccodigo.addFocusListener(this);
         edtavCloccodloccodigo.getGXComponent().setHelpId("HLP_WGx0090.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx0090_load16(this), new Gx0090_flow16(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 102, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 101 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A37MidCodi" ), "Código da mídia"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 101 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 87 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A35MidTipo" ), "Tipo da mídia"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 87 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 112 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A36MidSitu" ), "Situação da mídia"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 112 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 97, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 96 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A28FilCodi" ), "Código do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 96 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 144 , 456 , 193 ,  18 ));
         ((GXComboBox) subGrd_1.getColumn(1).getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) subGrd_1.getColumn(1).getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) subGrd_1.getColumn(1).getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) subGrd_1.getColumn(1).getGXComponent()).addItem( new java.lang.Short(4),"Box");
         ((GXComboBox) subGrd_1.getColumn(2).getGXComponent()).addItem( new java.lang.Short(1),"Liberado");
         ((GXComboBox) subGrd_1.getColumn(2).getGXComponent()).addItem( new java.lang.Short(2),"Locado");
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  495 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  495 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  495 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  495 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código da mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 93 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Tipo da mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 79 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Situação da mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 72 , 104 , 13 );
         lbllbl13 = UIFactory.getLabel(GXPanel1, "Código do filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 96 , 88 , 13 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Código da locação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 120 , 107 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCmidcodigo ,
                   cmbavCmidtipo ,
                   cmbavCmidsituacao ,
                   edtavCfilcodigo ,
                   edtavCloccodloccodigo ,
                   subGrd_1 ,
                   bttBtn_enter ,
                   bttBtn_cancel ,
                   bttBtn_refresh ,
                   bttBtn_help
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGrd_1, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile16( )
      {
         subwgx009016.setMidCodigo(A37MidCodi);
         subwgx009016.setMidTipo(A35MidTipo);
         subwgx009016.setMidSituacao(A36MidSitu);
         subwgx009016.setFilCodigo(A28FilCodi);
      }

      protected void subfileToVariables16( )
      {
         A37MidCodi = subwgx009016.getMidCodigo();
         A35MidTipo = subwgx009016.getMidTipo();
         A36MidSitu = subwgx009016.getMidSituacao();
         A28FilCodi = subwgx009016.getFilCodigo();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCmidcodigo.setValue( AV5cMidCod );
         cmbavCmidtipo.setValue( AV6cMidTip );
         cmbavCmidsituacao.setValue( AV7cMidSit );
         edtavCfilcodigo.setValue( AV8cFilCod );
         edtavCloccodloccodigo.setValue( AV9cLocCod );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5cMidCod = (int)(edtavCmidcodigo.getValue()) ;
         edtavCmidcodigo.setValue(AV5cMidCod);
         AV6cMidTip = (short)(cmbavCmidtipo.getValue()) ;
         cmbavCmidtipo.setValue(AV6cMidTip);
         AV7cMidSit = (short)(cmbavCmidsituacao.getValue()) ;
         cmbavCmidsituacao.setValue(AV7cMidSit);
         AV8cFilCod = (int)(edtavCfilcodigo.getValue()) ;
         edtavCfilcodigo.setValue(AV8cFilCod);
         AV9cLocCod = (int)(edtavCloccodloccodigo.getValue()) ;
         edtavCloccodloccodigo.setValue(AV9cLocCod);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGrd_1.inValidElement() )
         {
            subwgx009016 = ( subwgx009016 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx009016 = new subwgx009016 ();
         }
         subfileToVariables16 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile16 ();
         subGrd_1.refreshLineValue(subwgx009016);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx009016 = ( subwgx009016 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx009016 = new subwgx009016 ();
         }
         subfileToVariables16 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttBtn_cancel.isEventSource(eventSource) ) {
            if (canCleanup())
               this.cleanup();

            return;
         }
         if ( bttBtn_refresh.isEventSource(eventSource) ) {
            GXRefresh();
            return;
         }
         if ( bttBtn_help.isEventSource(eventSource) ) {
            showHelp();
            return;
         }
         if ( bttBtn_enter.isEventSource(eventSource) ) {
            /* Execute user event: E12V2K2 */
            E12V2K2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V2K2 */
            E12V2K2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCmidcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCmidcodigo.getGXCursor() );
            return;
         }
         if ( cmbavCmidtipo.isEventSource(eventSource) ) {
            setGXCursor( cmbavCmidtipo.getGXCursor() );
            return;
         }
         if ( cmbavCmidsituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbavCmidsituacao.getGXCursor() );
            return;
         }
         if ( edtavCfilcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCfilcodigo.getGXCursor() );
            return;
         }
         if ( edtavCloccodloccodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCloccodloccodigo.getGXCursor() );
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
         if ( edtavCmidcodigo.isEventSource(eventSource) ) {
            AV5cMidCod = edtavCmidcodigo.getValue() ;
            return;
         }
         if ( cmbavCmidtipo.isEventSource(eventSource) ) {
            AV6cMidTip = cmbavCmidtipo.getValue() ;
            return;
         }
         if ( cmbavCmidsituacao.isEventSource(eventSource) ) {
            AV7cMidSit = cmbavCmidsituacao.getValue() ;
            return;
         }
         if ( edtavCfilcodigo.isEventSource(eventSource) ) {
            AV8cFilCod = edtavCfilcodigo.getValue() ;
            return;
         }
         if ( edtavCloccodloccodigo.isEventSource(eventSource) ) {
            AV9cLocCod = edtavCloccodloccodigo.getValue() ;
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
            /* Execute user event: E12V2K2 */
            E12V2K2 ();
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

      public override IGXButton getCancelButton( )
      {
         return bttBtn_cancel ;
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
         this.AV10pMidCo = AV10pMidCo;
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
         subwgx009016 = new subwgx009016();
         scmdbuf = "" ;
         AV5cMidCod = 0 ;
         AV6cMidTip = 0 ;
         AV7cMidSit = 0 ;
         AV8cFilCod = 0 ;
         AV9cLocCod = 0 ;
         W002K2_A116LocCod = new int[1] ;
         W002K2_n116LocCod = new bool[] {false} ;
         W002K2_A28FilCodi = new int[1] ;
         W002K2_n28FilCodi = new bool[] {false} ;
         W002K2_A36MidSitu = new short[1] ;
         W002K2_n36MidSitu = new bool[] {false} ;
         W002K2_A35MidTipo = new short[1] ;
         W002K2_n35MidTipo = new bool[] {false} ;
         W002K2_A37MidCodi = new int[1] ;
         A116LocCod = 0 ;
         n116LocCod = false ;
         A28FilCodi = 0 ;
         n28FilCodi = false ;
         A36MidSitu = 0 ;
         n36MidSitu = false ;
         A35MidTipo = 0 ;
         n35MidTipo = false ;
         A37MidCodi = 0 ;
         gxIsRefreshing = false ;
         cV5cMidCod = 0 ;
         cV6cMidTip = 0 ;
         cV7cMidSit = 0 ;
         cV8cFilCod = 0 ;
         cV9cLocCod = 0 ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx0090__default(),
            new Object[][] {
                new Object[] {
               W002K2_A116LocCod, W002K2_n116LocCod, W002K2_A28FilCodi, W002K2_n28FilCodi, W002K2_A36MidSitu, W002K2_n36MidSitu, W002K2_A35MidTipo, W002K2_n35MidTipo, W002K2_A37MidCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV6cMidTip ;
      protected short AV7cMidSit ;
      protected short A36MidSitu ;
      protected short A35MidTipo ;
      protected short cV6cMidTip ;
      protected short cV7cMidSit ;
      protected int AV5cMidCod ;
      protected int AV8cFilCod ;
      protected int AV9cLocCod ;
      protected int A116LocCod ;
      protected int A28FilCodi ;
      protected int A37MidCodi ;
      protected int cV5cMidCod ;
      protected int cV8cFilCod ;
      protected int cV9cLocCod ;
      protected int AV10pMidCo ;
      protected String scmdbuf ;
      protected bool n116LocCod ;
      protected bool n28FilCodi ;
      protected bool n36MidSitu ;
      protected bool n35MidTipo ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx009016 subwgx009016 ;
      protected IDataReader W002K2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W002K2_A116LocCod ;
      protected bool[] W002K2_n116LocCod ;
      protected int[] W002K2_A28FilCodi ;
      protected bool[] W002K2_n28FilCodi ;
      protected short[] W002K2_A36MidSitu ;
      protected bool[] W002K2_n36MidSitu ;
      protected short[] W002K2_A35MidTipo ;
      protected bool[] W002K2_n35MidTipo ;
      protected int[] W002K2_A37MidCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCmidcodigo ;
      protected GUIObjectShort cmbavCmidtipo ;
      protected GUIObjectShort cmbavCmidsituacao ;
      protected GUIObjectInt edtavCfilcodigo ;
      protected GUIObjectInt edtavCloccodloccodigo ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl15 ;
      protected int aP0_pMidCodigo ;
   }

   public class wgx0090__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW002K2 ;
          prmW002K2 = new Object[] {
          new Object[] {"@AV5cMidCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cMidTip",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV7cMidSit",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV8cFilCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9cLocCod",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002K2", "SELECT [LocCodLocCodigo], [FilCodigo], [MidSituacao], [MidTipo], [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE ([MidCodigo] >= @AV5cMidCod) AND ([MidTipo] >= @AV6cMidTip) AND ([MidSituacao] >= @AV7cMidSit) AND ([FilCodigo] >= @AV8cFilCod) AND ([LocCodLocCodigo] >= @AV9cLocCod) ORDER BY [MidCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002K2,9,0,true,false )
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
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
       }
    }

 }

}
