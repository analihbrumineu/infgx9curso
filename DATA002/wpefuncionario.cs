/*
               File: PeFuncionario
        Description: Cadastro de funcionário.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:40:45.3
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
   public class wpefuncionario : GXWorkpanel
   {
      public wpefuncionario( int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpefuncionario( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpefuncionario( IGxContext context ,
                             int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeFuncionario" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de funcionário." ;
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
         return 1027 ;
      }

      public override int getFrmHeight( )
      {
         return 780 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeFuncionario.htm";
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

      public void runLoad_load02( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwpefuncionario02 = new subwpefuncionario02 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV7PesCodi ,
                                              AV8PesNome ,
                                              AV9PesFunC ,
                                              AV12PesFun ,
                                              A13PesCodi ,
                                              A14PesNome ,
                                              A39PesFunC ,
                                              A42PesFunD ,
                                              A38PesTipo },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W001K2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf2.getSize() < 10000 ) ) )
         {
            A41PesFunD = W001K2_A41PesFunD[0] ;
            n41PesFunD = W001K2_n41PesFunD[0] ;
            A38PesTipo = W001K2_A38PesTipo[0] ;
            n38PesTipo = W001K2_n38PesTipo[0] ;
            A42PesFunD = W001K2_A42PesFunD[0] ;
            n42PesFunD = W001K2_n42PesFunD[0] ;
            A39PesFunC = W001K2_A39PesFunC[0] ;
            n39PesFunC = W001K2_n39PesFunC[0] ;
            A14PesNome = W001K2_A14PesNome[0] ;
            n14PesNome = W001K2_n14PesNome[0] ;
            A13PesCodi = W001K2_A13PesCodi[0] ;
            /* Execute user event: E11V1K2 */
            E11V1K2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf2.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeFuncionario_load02 : GXLoadProducer
      {
         wpefuncionario _sf ;

         public PeFuncionario_load02( wpefuncionario uType ) : base()
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
         return new subwpefuncionario02 ();
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

      public class PeFuncionario_flow02 : GXSubfileFlow
      {
         wpefuncionario _sf ;

         public PeFuncionario_flow02( wpefuncionario uType ) : base()
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

      public override void GXStart( )
      {
         /* Execute user event: E12V1K2 */
         E12V1K2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V1K2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV9PesFunC = 0 ;
         cmbavPesfuncargo.setValue(AV9PesFunC);
      }

      public void loadToBuffer02( )
      {
         subwpefuncionario02 oAux = subwpefuncionario02 ;
         subwpefuncionario02 = new subwpefuncionario02 ();
         variablesToSubfile02 ();
         subGxsf2.addElement(subwpefuncionario02);
         subwpefuncionario02 = oAux;
      }

      private void E11V1K2( )
      {
         /* Load Routine */
         AV6Excluir = "c:\\KB\\DATA002\\bin\\deleteIcon.jpg" ;
         AV5Editar = "c:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         AV11Visual = "c:\\KB\\DATA002\\bin\\visualizarIcon.jpg" ;
         AV14Demiti = 0 ;
         if ( ( A41PesFunD != DateTimeUtil.CToD( "0", 2) ) )
         {
            AV14Demiti = 1 ;
         }
         subGxsf2.loadCommand();
      }

      protected void closeCursors02( )
      {
         pr_default.close(0);
      }

      protected void E13V1K2( )
      {
         eventLevelContext();
         /* Visualizar_Click Routine */
         new tfuncionario(context, base.remoteHandle, base.context).execute(  A13PesCodi,  "DSP") ;
         eventLevelResetContext();
      }

      protected void E14V1K2( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         new tfuncionario(context, base.remoteHandle, base.context).execute(  A13PesCodi,  "UPD") ;
         GXRefresh();
      }

      protected void E15V1K2( )
      {
         eventLevelContext();
         /* Excluir_Click Routine */
         new tfuncionario(context, base.remoteHandle, base.context).execute(  A13PesCodi,  "DLT") ;
         GXRefresh();
      }

      protected void E16V1K2( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tfuncionario(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 1027 , 780 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavPescodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),117, 67, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 117 , 67 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7PesCodi" );
         ((GXEdit) edtavPescodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavPescodigo.addFocusListener(this);
         edtavPescodigo.getGXComponent().setHelpId("HLP_WPeFuncionario.htm");
         edtavPesnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),247, 67, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 247 , 67 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8PesNome" );
         ((GXEdit) edtavPesnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesnome.addFocusListener(this);
         edtavPesnome.getGXComponent().setHelpId("HLP_WPeFuncionario.htm");
         cmbavPesfuncargo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 117 , 104 , 82 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9PesFunC" );
         ((GXComboBox) cmbavPesfuncargo.getGXComponent()).addItem( new java.lang.Short(0),"Todos");
         ((GXComboBox) cmbavPesfuncargo.getGXComponent()).addItem( new java.lang.Short(1),"Gerente");
         ((GXComboBox) cmbavPesfuncargo.getGXComponent()).addItem( new java.lang.Short(2),"Vendedor");
         cmbavPesfuncargo.addFocusListener(this);
         cmbavPesfuncargo.addItemListener(this);
         cmbavPesfuncargo.getGXComponent().setHelpId("HLP_WPeFuncionario.htm");
         edtavPesfundatadmissao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),273, 104, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 273 , 104 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV12PesFun" );
         ((GXEdit) edtavPesfundatadmissao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesfundatadmissao.addFocusListener(this);
         edtavPesfundatadmissao.getGXComponent().setHelpId("HLP_WPeFuncionario.htm");
         edtavPesfundatdemissao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),429, 104, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 429 , 104 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV13PesFun" );
         ((GXEdit) edtavPesfundatdemissao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesfundatdemissao.addFocusListener(this);
         edtavPesfundatdemissao.getGXComponent().setHelpId("HLP_WPeFuncionario.htm");
         addSubfile ( subGxsf2  = new GXSubfile ( new PeFuncionario_load02(this), new PeFuncionario_flow02(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV11Visual" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV5Editar" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV6Excluir" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 78, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 77 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A13PesCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 77 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 468, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 467 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A14PesNome" ), "Nome completo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 467 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 143 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A39PesFunC" ), "Cargo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 143 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 196, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 195 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A42PesFunD" ), "Data de admissão do funcionário"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 195 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectShort ( new GXCheckBox(GXPanel1, "" , new java.lang.Short(1), new java.lang.Short(0)) , null ,  0 , 0 , 58 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV14Demiti" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 58 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 34 , 18 , GXPanel1 , 65 , 130 , 885 , 637 ,  18 ));
         ((GXComboBox) subGxsf2.getColumn(5).getGXComponent()).addItem( new java.lang.Short(1),"Gerente");
         ((GXComboBox) subGxsf2.getColumn(5).getGXComponent()).addItem( new java.lang.Short(2),"Vendedor");
         subGxsf2.addActionListener(this);
         subGxsf2.addFocusListener(this);
         subGxsf2.setSortOnClick(true);
         subGxsf2.getColumn(0).addActionListener( this);
         subGxsf2.getColumn(0).addItemListener( this);
         subGxsf2.getColumn(1).addActionListener( this);
         subGxsf2.getColumn(1).addItemListener( this);
         subGxsf2.getColumn(2).addActionListener( this);
         subGxsf2.getColumn(2).addItemListener( this);
         bttbtt17 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  793 ,  91 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt17.setTooltip("Novo");
         bttbtt17.addActionListener(this);
         bttbtt17.setFiresEvents(false);
         lbllbl18 = UIFactory.getLabel(GXPanel1, "Cadastro de funcionário", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 136 , 13 );
         lbllbl14 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 71 , 40 , 13 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Nome", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 208 , 71 , 33 , 13 );
         lbllbl16 = UIFactory.getLabel(GXPanel1, "Cargo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 108 , 34 , 13 );
         lbllbl19 = UIFactory.getLabel(GXPanel1, "Admissão", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 208 , 108 , 54 , 13 );
         lbllbl20 = UIFactory.getLabel(GXPanel1, "Demissão", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 364 , 108 , 55 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavPescodigo ,
                   edtavPesnome ,
                   cmbavPesfuncargo ,
                   edtavPesfundatadmissao ,
                   edtavPesfundatdemissao ,
                   subGxsf2 ,
                   bttbtt17
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
         subwpefuncionario02.setVVisualizar(AV11Visual);
         subwpefuncionario02.setVEditar(AV5Editar);
         subwpefuncionario02.setVExcluir(AV6Excluir);
         subwpefuncionario02.setPesCodigo(A13PesCodi);
         subwpefuncionario02.setPesNome(A14PesNome);
         subwpefuncionario02.setPesFunCargo(A39PesFunC);
         subwpefuncionario02.setPesFunDatAdmissao(A42PesFunD);
         subwpefuncionario02.setVDemitido(AV14Demiti);
      }

      protected void subfileToVariables02( )
      {
         AV11Visual = subwpefuncionario02.getVVisualizar();
         AV5Editar = subwpefuncionario02.getVEditar();
         AV6Excluir = subwpefuncionario02.getVExcluir();
         A13PesCodi = subwpefuncionario02.getPesCodigo();
         A14PesNome = subwpefuncionario02.getPesNome();
         A39PesFunC = subwpefuncionario02.getPesFunCargo();
         A42PesFunD = subwpefuncionario02.getPesFunDatAdmissao();
         AV14Demiti = subwpefuncionario02.getVDemitido();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavPescodigo.setValue( AV7PesCodi );
         cmbavPesfuncargo.setValue( AV9PesFunC );
         edtavPesnome.setValue( AV8PesNome );
         edtavPesfundatadmissao.setValue( AV12PesFun );
         edtavPesfundatdemissao.setValue( AV13PesFun );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV7PesCodi = (int)(edtavPescodigo.getValue()) ;
         edtavPescodigo.setValue(AV7PesCodi);
         AV9PesFunC = (short)(cmbavPesfuncargo.getValue()) ;
         cmbavPesfuncargo.setValue(AV9PesFunC);
         AV8PesNome = (String)(edtavPesnome.getValue()) ;
         edtavPesnome.setValue(AV8PesNome);
         AV12PesFun = (DateTime)(edtavPesfundatadmissao.getValue()) ;
         edtavPesfundatadmissao.setValue(AV12PesFun);
         AV13PesFun = (DateTime)(edtavPesfundatdemissao.getValue()) ;
         edtavPesfundatdemissao.setValue(AV13PesFun);
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
            subwpefuncionario02 = ( subwpefuncionario02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpefuncionario02 = new subwpefuncionario02 ();
         }
         subfileToVariables02 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile02 ();
         subGxsf2.refreshLineValue(subwpefuncionario02);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf2.inValidElement() )
         {
            subwpefuncionario02 = ( subwpefuncionario02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpefuncionario02 = new subwpefuncionario02 ();
         }
         subfileToVariables02 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt17.isEventSource(eventSource) ) {
            /* Execute user event: E16V1K2 */
            E16V1K2 ();
            return;
         }
         if ( subGxsf2.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E13V1K2 */
            E13V1K2 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E14V1K2 */
            E14V1K2 ();
            return;
         }
         if ( subGxsf2.getColumn(2).isEventSource(eventSource) ) {
            /* Execute user event: E15V1K2 */
            E15V1K2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavPescodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavPescodigo.getGXCursor() );
            return;
         }
         if ( cmbavPesfuncargo.isEventSource(eventSource) ) {
            setGXCursor( cmbavPesfuncargo.getGXCursor() );
            return;
         }
         if ( edtavPesnome.isEventSource(eventSource) ) {
            setGXCursor( edtavPesnome.getGXCursor() );
            return;
         }
         if ( edtavPesfundatadmissao.isEventSource(eventSource) ) {
            setGXCursor( edtavPesfundatadmissao.getGXCursor() );
            return;
         }
         if ( edtavPesfundatdemissao.isEventSource(eventSource) ) {
            setGXCursor( edtavPesfundatdemissao.getGXCursor() );
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
            AV7PesCodi = edtavPescodigo.getValue() ;
            return;
         }
         if ( cmbavPesfuncargo.isEventSource(eventSource) ) {
            AV9PesFunC = cmbavPesfuncargo.getValue() ;
            return;
         }
         if ( edtavPesnome.isEventSource(eventSource) ) {
            AV8PesNome = edtavPesnome.getValue() ;
            return;
         }
         if ( edtavPesfundatadmissao.isEventSource(eventSource) ) {
            AV12PesFun = edtavPesfundatadmissao.getValue() ;
            return;
         }
         if ( edtavPesfundatdemissao.isEventSource(eventSource) ) {
            AV13PesFun = edtavPesfundatdemissao.getValue() ;
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
            /* Execute user event: E13V1K2 */
            E13V1K2 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V1K2 */
            E14V1K2 ();
            return;
         }
         if ( subGxsf2.getColumn(2).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E15V1K2 */
            E15V1K2 ();
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
         subwpefuncionario02 = new subwpefuncionario02();
         scmdbuf = "" ;
         AV7PesCodi = 0 ;
         AV8PesNome = "" ;
         AV9PesFunC = 0 ;
         AV12PesFun = (DateTime)(DateTime.MinValue) ;
         A13PesCodi = 0 ;
         A14PesNome = "" ;
         A39PesFunC = 0 ;
         A42PesFunD = (DateTime)(DateTime.MinValue) ;
         A38PesTipo = 0 ;
         W001K2_A41PesFunD = new DateTime[] {DateTime.MinValue} ;
         W001K2_n41PesFunD = new bool[] {false} ;
         W001K2_A38PesTipo = new short[1] ;
         W001K2_n38PesTipo = new bool[] {false} ;
         W001K2_A42PesFunD = new DateTime[] {DateTime.MinValue} ;
         W001K2_n42PesFunD = new bool[] {false} ;
         W001K2_A39PesFunC = new short[1] ;
         W001K2_n39PesFunC = new bool[] {false} ;
         W001K2_A14PesNome = new String[] {""} ;
         W001K2_n14PesNome = new bool[] {false} ;
         W001K2_A13PesCodi = new int[1] ;
         A41PesFunD = (DateTime)(DateTime.MinValue) ;
         n41PesFunD = false ;
         n38PesTipo = false ;
         n42PesFunD = false ;
         n39PesFunC = false ;
         n14PesNome = false ;
         gxIsRefreshing = false ;
         returnInSub = false ;
         AV6Excluir = "" ;
         AV5Editar = "" ;
         AV11Visual = "" ;
         AV14Demiti = 0 ;
         AV13PesFun = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpefuncionario__default(),
            new Object[][] {
                new Object[] {
               W001K2_A41PesFunD, W001K2_n41PesFunD, W001K2_A38PesTipo, W001K2_n38PesTipo, W001K2_A42PesFunD, W001K2_n42PesFunD, W001K2_A39PesFunC, W001K2_n39PesFunC, W001K2_A14PesNome, W001K2_n14PesNome,
               W001K2_A13PesCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV9PesFunC ;
      protected short A39PesFunC ;
      protected short A38PesTipo ;
      protected short AV14Demiti ;
      protected int AV7PesCodi ;
      protected int A13PesCodi ;
      protected String scmdbuf ;
      protected DateTime AV12PesFun ;
      protected DateTime A42PesFunD ;
      protected DateTime A41PesFunD ;
      protected DateTime AV13PesFun ;
      protected bool n41PesFunD ;
      protected bool n38PesTipo ;
      protected bool n42PesFunD ;
      protected bool n39PesFunC ;
      protected bool n14PesNome ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String AV8PesNome ;
      protected String A14PesNome ;
      protected String AV6Excluir ;
      protected String AV5Editar ;
      protected String AV11Visual ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpefuncionario02 subwpefuncionario02 ;
      protected IDataReader W001K2 ;
      protected IDataStoreProvider pr_default ;
      protected DateTime[] W001K2_A41PesFunD ;
      protected bool[] W001K2_n41PesFunD ;
      protected short[] W001K2_A38PesTipo ;
      protected bool[] W001K2_n38PesTipo ;
      protected DateTime[] W001K2_A42PesFunD ;
      protected bool[] W001K2_n42PesFunD ;
      protected short[] W001K2_A39PesFunC ;
      protected bool[] W001K2_n39PesFunC ;
      protected String[] W001K2_A14PesNome ;
      protected bool[] W001K2_n14PesNome ;
      protected int[] W001K2_A13PesCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavPescodigo ;
      protected GUIObjectString edtavPesnome ;
      protected GUIObjectShort cmbavPesfuncargo ;
      protected GUIObjectDatetime edtavPesfundatadmissao ;
      protected GUIObjectDatetime edtavPesfundatdemissao ;
      protected GXSubfile subGxsf2 ;
      protected IGXButton bttbtt17 ;
      protected ILabel lbllbl18 ;
      protected ILabel lbllbl14 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl16 ;
      protected ILabel lbllbl19 ;
      protected ILabel lbllbl20 ;
   }

   public class wpefuncionario__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W001K2( int AV7PesCodi ,
                                           String AV8PesNome ,
                                           short AV9PesFunC ,
                                           DateTime AV12PesFun ,
                                           int A13PesCodi ,
                                           String A14PesNome ,
                                           short A39PesFunC ,
                                           DateTime A42PesFunD ,
                                           short A38PesTipo )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [PesFunDatDemissao], [PesTipo], [PesFunDatAdmissao], [PesFunCargo], [PesNome], [PesCodigo] FROM [PESSOA] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([PesTipo] = 2)" ;
         sWhereString = "" ;
         if ( ( AV7PesCodi != 0 ) )
         {
            sWhereString = sWhereString + " and ([PesCodigo] = " + StringUtil.Str( (decimal)(AV7PesCodi), 9, 0) + ")" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV8PesNome).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and ([PesNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV8PesNome, "'", "''")), 50, "%") + "')" ;
         }
         if ( ( AV9PesFunC != 0 ) )
         {
            sWhereString = sWhereString + " and ([PesFunCargo] = " + StringUtil.Str( (decimal)(AV9PesFunC), 1, 0) + ")" ;
         }
         if ( ( AV12PesFun != DateTimeUtil.CToD( "0", 2) ) )
         {
            sWhereString = sWhereString + " and ([PesFunDatAdmissao] = " + ((AV12PesFun>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV12PesFun, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
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
                     return conditional_W001K2( (int)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (DateTime)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
          Object[] prmW001K2 ;
          prmW001K2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W001K2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW001K2,27,0,true,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
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
