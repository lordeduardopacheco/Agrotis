using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agrotis.Zoom;
using Modelo;
using Modelo.Repository;

namespace Agrotis.Cadastro
{
    public partial class CadastroPadrao : Form
    {
        protected Modelo.BancoAgrotisEntitiesModelo context = new BancoAgrotisEntitiesModelo();
        protected String classe = "";
        protected Boolean novo = false;

        public CadastroPadrao()
        {
            InitializeComponent();
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            btnConsultar.Enabled = true;
            btnSalvar.Enabled = false;
            tabPadrao.Enabled = false;
            novo = false;
        }

        protected void Estados(String Tipo)
        {

        }

        protected  Boolean ValidaDados()
        {
            Type t = Type.GetType("Modelo.Service." + classe.Replace("Modelo.", "") + "Service,Modelo");
            Object obj = Activator.CreateInstance(t);
            Type objType = obj.GetType();
            MethodInfo method = objType.GetMethod("Valida");
            String resultado = (String) method.Invoke(obj, new Object[] { bindingSource.Current });
            if(resultado == "OK")
            {
                return true;
            }
            MessageBox.Show(resultado);
            return false;
        }

        protected virtual void AntesSalvar()
        {

        }

        protected virtual void DepoisSalvar()
        {


        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                try
                {
                    bindingSource.EndEdit();
                    AntesSalvar();
                    if (novo)
                    {
                        Type t = Type.GetType("Modelo." + classe.Replace("Modelo.", "") + ",Modelo");
                        context.Set(t).Add(bindingSource.Current);
                    }
                    Boolean bol = context.ChangeTracker.HasChanges();
                    context.SaveChanges();
                    DepoisSalvar();
                    MessageBox.Show("Salvo com sucesso!");
                    btnCancelar.PerformClick();
                }
                catch(DbEntityValidationException dex)
                {
                    foreach (var eve in dex.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    MessageBox.Show("Erro ao salvar: " + dex.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.ToString());
                }

            }
        }

        private void CadastroPadrao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (context.ChangeTracker.HasChanges())
            {
                if (MessageBox.Show("Alterações foram feitas, tem certeza que deseja sair sem salvar?", "Tabelas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void CadastroPadrao_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            context = new BancoAgrotisEntitiesModelo();
            bindingSource.AddNew();
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnConsultar.Enabled = false;
            btnSalvar.Enabled = true;
            tabPadrao.Enabled = true;
            novo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bindingSource.CancelEdit();
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            btnConsultar.Enabled = true;
            btnSalvar.Enabled = false;
            tabPadrao.Enabled = false;
            novo = false;
        }

        private void CadastroPadrao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.ProcessTabKey(true);
            }
        }

        private void CadastroPadrao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void AtualizaBS(String metodo, Object o = null)
        {
            Type t = Type.GetType("Modelo.Repository.Zoom" + classe.Replace("Modelo.", "") + "Repository,Modelo");
            Object obj = Activator.CreateInstance(t);
            Type objType = obj.GetType();
            MethodInfo method = objType.GetMethod(metodo);
            if (metodo == "getList")
            {
                bindingSource.DataSource = method.Invoke(obj, new Object[] { context });
            }
            else
            {
                bindingSource.DataSource = method.Invoke(obj, new Object[] { context, o });
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String tipo = "Agrotis.Zoom.Zoom" + classe;
            Type type = Type.GetType(tipo);
            Object obj = Activator.CreateInstance(type);
            ZoomPadrao frm = (ZoomPadrao)obj;
            frm.classe = classe;
            frm.ShowDialog();
            if (frm.objeto == null)
            {
                btnCancelar.PerformClick();
            }
            else
            {
                AtualizaBS("getObjeto", frm.objeto);
            }
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnConsultar.Enabled = false;
            btnSalvar.Enabled = true;
            tabPadrao.Enabled = true;
            novo = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroPadrao_Shown(object sender, EventArgs e)
        {
            try
            {
                String tipo = "Modelo.Repository.Zoom" + classe.Replace("Modelo.", "") + "Repository,Modelo";
                Type t = Type.GetType(tipo);
                Object obj = Activator.CreateInstance(t);
                Type objType = obj.GetType();
                MethodInfo method = objType.GetMethod("getList");
                bindingSource.DataSource = method.Invoke(obj, new Object[] { context });
            }
            catch (Exception ex)
            {

            }
        }
    }
}
