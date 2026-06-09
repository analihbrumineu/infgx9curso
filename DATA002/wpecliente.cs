/*
               File: PeCliente
        Description: Cadastro de clientes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 11:37:38.34
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
   public class wpecliente : GXWorkpanel
   {
      public wpecliente( int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpecliente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpecliente( IGxContext context ,
                         int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeCliente" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de clientes." ;
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
         return 819 ;
      }

      public override int getFrmHeight( )
      {
         return 780 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeCliente.htm";
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
      }

      public void runLoad_load11( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwpecliente11 = new subwpecliente11 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV5PesCodi ,
                                              AV6PesNome ,
                                              AV13PesSit ,
                                              AV9PesBair ,
                                              A13PesCodi ,
                                              A14PesNome ,
                                              A23PesSitu ,
                                              A19PesBair ,
                                              AV14DepTod ,
                                              A48PesDepT ,
                                              AV12PesDep ,
                                              A38PesTipo },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.INT, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000S2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf11.getSize() < 10000 ) ) )
         {
            A38PesTipo = W000S2_A38PesTipo[0] ;
            n38PesTipo = W000S2_n38PesTipo[0] ;
            A19PesBair = W000S2_A19PesBair[0] ;
            n19PesBair = W000S2_n19PesBair[0] ;
            A23PesSitu = W000S2_A23PesSitu[0] ;
            n23PesSitu = W000S2_n23PesSitu[0] ;
            A14PesNome = W000S2_A14PesNome[0] ;
            n14PesNome = W000S2_n14PesNome[0] ;
            A13PesCodi = W000S2_A13PesCodi[0] ;
            A48PesDepT = GetPesDepTotal0( A13PesCodi) ;
            if ( ( AV14DepTod != 0 ) || ( ( A48PesDepT == AV12PesDep ) ) )
            {
               /* Execute user event: E11V0S2 */
               E11V0S2 ();
            }
            pr_default.readNext(0);
         }
         if ( subGxsf11.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeCliente_load11 : GXLoadProducer
      {
         wpecliente _sf ;

         public PeCliente_load11( wpecliente uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer11();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load11();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors11();
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
            subGxsf11.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow11( )
      {
         return true;
      }

      public void autoRefresh_flow11( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV12PesDep!=cV12PesDep)||(AV14DepTod!=cV14DepTod) ) || (!loadedFirstTime && ! isLoadAtStartup_flow11() )) {
            subfile.refresh();
            resetSubfileConditions_flow11() ;
         }
      }

      public bool getSearch_flow11( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow11( )
      {
         cV12PesDep = AV12PesDep ;
         cV14DepTod = AV14DepTod ;
      }

      public void resetSearchConditions_flow11( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow11( )
      {
         return new subwpecliente11 ();
      }

      public bool getSearch_flow11( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow11( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow11( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow11( )
      {
         GXRefreshCommand11 ();
      }

      public class PeCliente_flow11 : GXSubfileFlow
      {
         wpecliente _sf ;

         public PeCliente_flow11( wpecliente uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow11();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow11(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow11();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow11();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow11(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow11();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow11(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow11(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow11(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow11();
         }

      }

      protected void GXRefreshCommand11( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXStart( )
      {
         /* Execute user event: E12V0S2 */
         E12V0S2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V0S2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV13PesSit = 9 ;
         cmbavPessituacao.setValue(AV13PesSit);
         AV14DepTod = 1 ;
         chkavDeptodos.setValue(AV14DepTod);
         edtavPesdeptotal.setEnabled(0);
      }

      public void loadToBuffer11( )
      {
         subwpecliente11 oAux = subwpecliente11 ;
         subwpecliente11 = new subwpecliente11 ();
         variablesToSubfile11 ();
         subGxsf11.addElement(subwpecliente11);
         subwpecliente11 = oAux;
      }

      private void E11V0S2( )
      {
         /* Load Routine */
         AV11Exclui = "c:\\KB\\DATA002\\bin\\deleteIcon.jpg" ;
         AV10Editar = "c:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         AV15Visual = "c:\\KB\\DATA002\\bin\\visualizarIcon.jpg" ;
         subGxsf11.loadCommand();
      }

      protected void closeCursors11( )
      {
         pr_default.close(0);
      }

      protected void E13V0S2( )
      {
         eventLevelContext();
         /* Visualizar_Click Routine */
         new tcliente(context, base.remoteHandle, base.context).execute(  A13PesCodi,  "DSP") ;
         eventLevelResetContext();
      }

      protected void E14V0S2( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         new tcliente(context, base.remoteHandle, base.context).execute(  A13PesCodi,  "UPD") ;
         GXRefresh();
      }

      protected void E15V0S2( )
      {
         eventLevelContext();
         /* Excluir_Click Routine */
         new tcliente(context, base.remoteHandle, base.context).execute(  A13PesCodi,  "DLT") ;
         GXRefresh();
      }

      protected void E16V0S2( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tcliente(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      protected void E17V0S2( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("AV5PesCodi") )
         {
            GXt_svchar1 = "X" ;
            new wconscliente(context, base.remoteHandle, base.context).execute( ref  GXt_svchar1, out  AV5PesCodi) ;
            edtavPescodigo.setValue( AV5PesCodi );
         }
         eventLevelResetContext();
      }

      protected void E18V0S2( )
      {
         eventLevelContext();
         /* Deptodos_Click Routine */
         if ( ( AV14DepTod == 1 ) )
         {
            edtavPesdeptotal.setEnabled(0);
            AV12PesDep = 0 ;
            edtavPesdeptotal.setValue(AV12PesDep);
         }
         else
         {
            edtavPesdeptotal.setEnabled(1);
         }
         eventLevelResetContext();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 819 , 780 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavPescodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),117, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 117 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5PesCodi" );
         ((GXEdit) edtavPescodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavPescodigo.addFocusListener(this);
         edtavPescodigo.getGXComponent().setHelpId("HLP_WPeCliente.htm");
         cmbavPessituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 494 , 65 , 130 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV13PesSit" );
         ((GXComboBox) cmbavPessituacao.getGXComponent()).addItem( new java.lang.Short(9),"Todos");
         ((GXComboBox) cmbavPessituacao.getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) cmbavPessituacao.getGXComponent()).addItem( new java.lang.Short(0),"Inativo");
         cmbavPessituacao.addFocusListener(this);
         cmbavPessituacao.addItemListener(this);
         cmbavPessituacao.getGXComponent().setHelpId("HLP_WPeCliente.htm");
         edtavPesnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),117, 91, 273, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 117 , 91 , 273 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6PesNome" );
         ((GXEdit) edtavPesnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesnome.addFocusListener(this);
         edtavPesnome.getGXComponent().setHelpId("HLP_WPeCliente.htm");
         edtavPesdeptotal = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),494, 91, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 494 , 91 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV12PesDep" );
         ((GXEdit) edtavPesdeptotal.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavPesdeptotal.addFocusListener(this);
         edtavPesdeptotal.getGXComponent().setHelpId("HLP_WPeCliente.htm");
         chkavDeptodos = new GUIObjectShort ( new GXCheckBox(GXPanel1, "Todos" , new java.lang.Short(1), new java.lang.Short(0)) , GXPanel1 , 585 , 93 , 56 , 17 , Integer.MAX_VALUE , UIFactory.getColor(17) , UIFactory.getFont( "Courier New", IFontConstants.BOLD, 9) , true , "AV14DepTod" );
         chkavDeptodos.addFocusListener(this);
         chkavDeptodos.addItemListener(this);
         chkavDeptodos.getGXComponent().setHelpId("HLP_WPeCliente.htm");
         edtavPesbairro = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),117, 117, 273, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 117 , 117 , 273 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9PesBair" );
         ((GXEdit) edtavPesbairro.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesbairro.addFocusListener(this);
         edtavPesbairro.getGXComponent().setHelpId("HLP_WPeCliente.htm");
         addSubfile ( subGxsf11  = new GXSubfile ( new PeCliente_load11(this), new PeCliente_flow11(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV15Visual" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV10Editar" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV11Exclui" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 52, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 51 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A13PesCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 51 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 289, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 288 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A14PesNome" ), "Nome"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 288 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 93, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 92 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A48PesDepT" ), "Dependente(s)"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 92 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 122 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A23PesSitu" ), "Situação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 122 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 32 , 18 , GXPanel1 , 65 , 156 , 693 , 598 ,  18 ));
         ((GXComboBox) subGxsf11.getColumn(6).getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) subGxsf11.getColumn(6).getGXComponent()).addItem( new java.lang.Short(0),"Inativo");
         subGxsf11.addActionListener(this);
         subGxsf11.addFocusListener(this);
         subGxsf11.setSortOnClick(true);
         subGxsf11.getColumn(0).addActionListener( this);
         subGxsf11.getColumn(0).addItemListener( this);
         subGxsf11.getColumn(1).addActionListener( this);
         subGxsf11.getColumn(1).addItemListener( this);
         subGxsf11.getColumn(2).addActionListener( this);
         subGxsf11.getColumn(2).addItemListener( this);
         bttbtt2 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  624 ,  117 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt2.setTooltip("Novo");
         bttbtt2.addActionListener(this);
         bttbtt2.setFiresEvents(false);
         lbllbl19 = UIFactory.getLabel(GXPanel1, "Cadastro de clientes", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 117 , 13 );
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 69 , 40 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 403 , 69 , 51 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Nome", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 95 , 33 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Dependente(s)", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 403 , 95 , 84 , 13 );
         lbllbl21 = UIFactory.getLabel(GXPanel1, "Bairro", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 121 , 34 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavPescodigo ,
                   cmbavPessituacao ,
                   edtavPesnome ,
                   edtavPesdeptotal ,
                   chkavDeptodos ,
                   edtavPesbairro ,
                   subGxsf11 ,
                   bttbtt2
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf11, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile11( )
      {
         subwpecliente11.setVVisualizar(AV15Visual);
         subwpecliente11.setVEditar(AV10Editar);
         subwpecliente11.setVExcluir(AV11Exclui);
         subwpecliente11.setPesCodigo(A13PesCodi);
         subwpecliente11.setPesNome(A14PesNome);
         subwpecliente11.setPesDepTotal(A48PesDepT);
         subwpecliente11.setPesSituacao(A23PesSitu);
      }

      protected void subfileToVariables11( )
      {
         AV15Visual = subwpecliente11.getVVisualizar();
         AV10Editar = subwpecliente11.getVEditar();
         AV11Exclui = subwpecliente11.getVExcluir();
         A13PesCodi = subwpecliente11.getPesCodigo();
         A14PesNome = subwpecliente11.getPesNome();
         A48PesDepT = subwpecliente11.getPesDepTotal();
         A23PesSitu = subwpecliente11.getPesSituacao();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavPescodigo.setValue( AV5PesCodi );
         edtavPesdeptotal.setValue( AV12PesDep );
         edtavPesnome.setValue( AV6PesNome );
         cmbavPessituacao.setValue( AV13PesSit );
         chkavDeptodos.setValue( AV14DepTod );
         edtavPesbairro.setValue( AV9PesBair );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5PesCodi = (int)(edtavPescodigo.getValue()) ;
         edtavPescodigo.setValue(AV5PesCodi);
         AV12PesDep = (int)(edtavPesdeptotal.getValue()) ;
         edtavPesdeptotal.setValue(AV12PesDep);
         AV6PesNome = (String)(edtavPesnome.getValue()) ;
         edtavPesnome.setValue(AV6PesNome);
         AV13PesSit = (short)(cmbavPessituacao.getValue()) ;
         cmbavPessituacao.setValue(AV13PesSit);
         AV14DepTod = (short)(chkavDeptodos.getValue()) ;
         chkavDeptodos.setValue(AV14DepTod);
         AV9PesBair = (String)(edtavPesbairro.getValue()) ;
         edtavPesbairro.setValue(AV9PesBair);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf11.inValidElement() )
         {
            subwpecliente11 = ( subwpecliente11 ) subGxsf11.getCurrentElement() ;
         }
         else
         {
            subwpecliente11 = new subwpecliente11 ();
         }
         subfileToVariables11 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile11 ();
         subGxsf11.refreshLineValue(subwpecliente11);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf11.inValidElement() )
         {
            subwpecliente11 = ( subwpecliente11 ) subGxsf11.getCurrentElement() ;
         }
         else
         {
            subwpecliente11 = new subwpecliente11 ();
         }
         subfileToVariables11 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt2.isEventSource(eventSource) ) {
            /* Execute user event: E16V0S2 */
            E16V0S2 ();
            return;
         }
         if ( subGxsf11.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf11.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E13V0S2 */
            E13V0S2 ();
            return;
         }
         if ( subGxsf11.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E14V0S2 */
            E14V0S2 ();
            return;
         }
         if ( subGxsf11.getColumn(2).isEventSource(eventSource) ) {
            /* Execute user event: E15V0S2 */
            E15V0S2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavPescodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavPescodigo.getGXCursor() );
            return;
         }
         if ( edtavPesdeptotal.isEventSource(eventSource) ) {
            setGXCursor( edtavPesdeptotal.getGXCursor() );
            return;
         }
         if ( edtavPesnome.isEventSource(eventSource) ) {
            setGXCursor( edtavPesnome.getGXCursor() );
            return;
         }
         if ( cmbavPessituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbavPessituacao.getGXCursor() );
            return;
         }
         if ( chkavDeptodos.isEventSource(eventSource) ) {
            setGXCursor( chkavDeptodos.getGXCursor() );
            return;
         }
         if ( edtavPesbairro.isEventSource(eventSource) ) {
            setGXCursor( edtavPesbairro.getGXCursor() );
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
         if ( edtavPescodigo.isEventSource(eventSource) ) {
            AV5PesCodi = edtavPescodigo.getValue() ;
            return;
         }
         if ( edtavPesdeptotal.isEventSource(eventSource) ) {
            AV12PesDep = edtavPesdeptotal.getValue() ;
            return;
         }
         if ( edtavPesnome.isEventSource(eventSource) ) {
            AV6PesNome = edtavPesnome.getValue() ;
            return;
         }
         if ( cmbavPessituacao.isEventSource(eventSource) ) {
            AV13PesSit = cmbavPessituacao.getValue() ;
            return;
         }
         if ( chkavDeptodos.isEventSource(eventSource) ) {
            AV14DepTod = chkavDeptodos.getValue() ;
            return;
         }
         if ( edtavPesbairro.isEventSource(eventSource) ) {
            AV9PesBair = edtavPesbairro.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
         if ( chkavDeptodos.isEventSource(eventSource) ) {
            /* Execute user event: E18V0S2 */
            E18V0S2 ();
            return;
         }
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf11.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V0S2 */
            E13V0S2 ();
            return;
         }
         if ( subGxsf11.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0S2 */
            E14V0S2 ();
            return;
         }
         if ( subGxsf11.getColumn(2).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E15V0S2 */
            E15V0S2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E17V0S2 */
            E17V0S2 ();
            return true ;
         }
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

      protected int GetPesDepTotal0( int E13PesCodi )
      {
         Gx_cnt = 0 ;
         /* Using cursor W000S3 */
         pr_default.execute(1, new Object[] {E13PesCodi});
         if ( (pr_default.getStatus(1) != 101) )
         {
            Gx_cnt = W000S3_Gx_cnt[0] ;
         }
         pr_default.close(1);
         return Gx_cnt ;
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
         subwpecliente11 = new subwpecliente11();
         scmdbuf = "" ;
         AV5PesCodi = 0 ;
         AV6PesNome = "" ;
         AV13PesSit = 0 ;
         AV9PesBair = "" ;
         A13PesCodi = 0 ;
         A14PesNome = "" ;
         A23PesSitu = 0 ;
         A19PesBair = "" ;
         AV14DepTod = 0 ;
         A48PesDepT = 0 ;
         AV12PesDep = 0 ;
         A38PesTipo = 0 ;
         W000S2_A38PesTipo = new short[1] ;
         W000S2_n38PesTipo = new bool[] {false} ;
         W000S2_A19PesBair = new String[] {""} ;
         W000S2_n19PesBair = new bool[] {false} ;
         W000S2_A23PesSitu = new short[1] ;
         W000S2_n23PesSitu = new bool[] {false} ;
         W000S2_A14PesNome = new String[] {""} ;
         W000S2_n14PesNome = new bool[] {false} ;
         W000S2_A13PesCodi = new int[1] ;
         n38PesTipo = false ;
         n19PesBair = false ;
         n23PesSitu = false ;
         n14PesNome = false ;
         gxIsRefreshing = false ;
         cV12PesDep = 0 ;
         cV14DepTod = 0 ;
         returnInSub = false ;
         AV11Exclui = "" ;
         AV10Editar = "" ;
         AV15Visual = "" ;
         GXt_svchar1 = "" ;
         Gx_cnt = 0 ;
         E13PesCodi = 0 ;
         W000S3_Gx_cnt = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpecliente__default(),
            new Object[][] {
                new Object[] {
               W000S2_A38PesTipo, W000S2_n38PesTipo, W000S2_A19PesBair, W000S2_n19PesBair, W000S2_A23PesSitu, W000S2_n23PesSitu, W000S2_A14PesNome, W000S2_n14PesNome, W000S2_A13PesCodi
               }
               , new Object[] {
               W000S3_Gx_cnt
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV13PesSit ;
      protected short A23PesSitu ;
      protected short AV14DepTod ;
      protected short A38PesTipo ;
      protected short cV14DepTod ;
      protected int AV5PesCodi ;
      protected int A13PesCodi ;
      protected int A48PesDepT ;
      protected int AV12PesDep ;
      protected int cV12PesDep ;
      protected int Gx_cnt ;
      protected int E13PesCodi ;
      protected String scmdbuf ;
      protected bool n38PesTipo ;
      protected bool n19PesBair ;
      protected bool n23PesSitu ;
      protected bool n14PesNome ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String AV6PesNome ;
      protected String AV9PesBair ;
      protected String A14PesNome ;
      protected String A19PesBair ;
      protected String GXt_svchar1 ;
      protected String AV11Exclui ;
      protected String AV10Editar ;
      protected String AV15Visual ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpecliente11 subwpecliente11 ;
      protected IDataReader W000S2 ;
      protected IDataStoreProvider pr_default ;
      protected short[] W000S2_A38PesTipo ;
      protected bool[] W000S2_n38PesTipo ;
      protected String[] W000S2_A19PesBair ;
      protected bool[] W000S2_n19PesBair ;
      protected short[] W000S2_A23PesSitu ;
      protected bool[] W000S2_n23PesSitu ;
      protected String[] W000S2_A14PesNome ;
      protected bool[] W000S2_n14PesNome ;
      protected int[] W000S2_A13PesCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavPescodigo ;
      protected GUIObjectShort cmbavPessituacao ;
      protected GUIObjectString edtavPesnome ;
      protected GUIObjectInt edtavPesdeptotal ;
      protected GUIObjectShort chkavDeptodos ;
      protected GUIObjectString edtavPesbairro ;
      protected GXSubfile subGxsf11 ;
      protected IGXButton bttbtt2 ;
      protected ILabel lbllbl19 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl8 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl21 ;
      protected IDataReader W000S3 ;
      protected int[] W000S3_Gx_cnt ;
   }

   public class wpecliente__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000S2( int AV5PesCodi ,
                                           String AV6PesNome ,
                                           short AV13PesSit ,
                                           String AV9PesBair ,
                                           int A13PesCodi ,
                                           String A14PesNome ,
                                           short A23PesSitu ,
                                           String A19PesBair ,
                                           short AV14DepTod ,
                                           int A48PesDepT ,
                                           int AV12PesDep ,
                                           short A38PesTipo )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [PesTipo], [PesBairro], [PesSituacao], [PesNome], [PesCodigo] FROM [PESSOA] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([PesTipo] = 1)" ;
         sWhereString = "" ;
         if ( ( AV5PesCodi != 0 ) )
         {
            sWhereString = sWhereString + " and ([PesCodigo] = " + StringUtil.Str( (decimal)(AV5PesCodi), 9, 0) + ")" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV6PesNome).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and ([PesNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6PesNome, "'", "''")), 50, "%") + "')" ;
         }
         if ( ( AV13PesSit != 9 ) )
         {
            sWhereString = sWhereString + " and ([PesSituacao] = " + StringUtil.Str( (decimal)(AV13PesSit), 1, 0) + ")" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV9PesBair).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and ([PesBairro] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV9PesBair, "'", "''")), 50, "%") + "')" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [PesCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000S2( (int)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (int)dynConstraints[9] , (int)dynConstraints[10] , (short)dynConstraints[11] );
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
          Object[] prmW000S3 ;
          prmW000S3 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmW000S2 ;
          prmW000S2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000S2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000S2,26,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000S3", "SELECT COUNT(*) FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000S3,1,0,true,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
                break;
             case 1 :
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
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
