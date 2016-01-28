using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ovjust.WinformTest
{
    public partial class FormAPath : Form
    {
        public FormAPath()
        {
            InitializeComponent();
        }
        class Block
        {
            public int X { set; get; }
            public int Y { set; get; }
            public Block(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        class RouteNode
        {
            public Block NodeBlock { set; get; }
            public int StraightScore { set; get; }//路径搜索时 越小越好
            public int ForcastScore { set; get; }
            public List<RouteNode> NextNodes { set; get; }
            public RouteNode ParentNode { set; get; }
            public bool DeActive { set; get; }
        }
        Graphics graphics;
        Block blockStart, blockEnd;
        List<Block> blockStops = new List<Block>();
        Color colorStart = Color.Green;
        Color colorEnd = Color.Red;
        Color colorStop = Color.Gray;
        Color colorPath = Color.MediumBlue;
        private void FormAPath_Load(object sender, EventArgs e)
        {
            Bitmap bMap = new Bitmap(pictureBox1.Height,pictureBox1.Height);
            pictureBox1.Image = bMap;
            graphics = Graphics.FromImage(bMap);
            DrawMapLines();
            //
        }

        private void DrawMapLines()
        {
            Pen myPen = new Pen(Color.Red, 1);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //Rectangle rect = new Rectangle(140, 40, 190, 280);
            //graphics.DrawRectangle(myPen, rect);
            for (var i = 0; i <= 10; i++)
            {
                var posi = 1 + 40 * i;
                graphics.DrawLine(myPen, new Point(1, posi), new Point(401, posi));//横线
                graphics.DrawLine(myPen, new Point(posi, 1), new Point(posi, 401));//竖线
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var curNode = new RouteNode() { NodeBlock = blockStart };
            //List<RouteNode> closed = new List<RouteNode>();
            RouteFindNexts(curNode);

           var lastNode= closed.Last();
           
           while (lastNode.ParentNode != null)
           {
               graphics.DrawRectangle(new Pen(colorStop, 1), new Rectangle(lastNode.NodeBlock.X * 40 + 5, lastNode.NodeBlock.Y * 40 + 5, 30, 30));
               lastNode = lastNode.ParentNode;
           }
           pictureBox1.Refresh();
            //
        }

        private void RouteFindNexts(RouteNode curNode)
        {
            List<RouteNode> closedNodes = new List<RouteNode>();
            {
                var parentNode = curNode.ParentNode;
                while (parentNode != null)
                    closedNodes.Add(parentNode);
            }
            //closed.Add(curNode);
            curNode.NextNodes = new List<RouteNode>();
            var nearBlocks = new List<Block>();
            for (var i = -1; i <= 1; i += 2)
            {
                {
                    var block = new Block(curNode.NodeBlock.X + i, curNode.NodeBlock.Y);
                    CheckNearBlockAdd(closedNodes, nearBlocks, block);
                }
                {
                    var block = new Block(curNode.NodeBlock.X, curNode.NodeBlock.Y + i);
                    CheckNearBlockAdd(closedNodes, nearBlocks, block);
                }
            }
            if (nearBlocks.Count == 0)//走到死路
            {
                curNode.DeActive = true;
                var parent = curNode.ParentNode;
                while (parent != null && parent.NextNodes.All(p => p.DeActive == true))
                {
                    parent.DeActive = true;
                    parent = parent.ParentNode;
                }
                if (parent == null)
                {
                    MessageBox.Show("未找到路径");
                    return;
                }
                var bestNode = parent.NextNodes.Where(p => p.DeActive == false).OrderBy(p => p.ForcastScore).First();
                parent.ForcastScore = bestNode.ForcastScore + 1;
                RouteFindNexts(bestNode);
            }
            else if (nearBlocks.Any(p => p.X == blockEnd.X && p.Y == blockEnd.Y))//找到终点
            {
                //curNode.NextNodes.Add(new RouteNode() { NodeBlock = blockEnd });
                MessageBox.Show("找到路径");
            }
            else
            {
                foreach (var block in nearBlocks)
                {
                    var node = new RouteNode() { NodeBlock = block, ParentNode = curNode };
                    node.StraightScore = Math.Abs(block.X - blockEnd.X) + Math.Abs(block.Y - blockEnd.Y);
                    node.ForcastScore = node.StraightScore;
                    curNode.NextNodes.Add(node);
                }
                var bestNode = curNode.NextNodes.OrderBy(p => p.ForcastScore).First();
                if (bestNode.ForcastScore >= curNode.ForcastScore)
                    curNode.ForcastScore = bestNode.ForcastScore + 1;
                RouteFindNexts(bestNode);
            }
        }

        private void CheckNearBlockAdd(List<RouteNode> closed, List<Block> nearBlocks, Block block)
        {
            if (block.X > 0 && block.X <= 10 && block.Y > 0 && block.Y <= 10
                && !blockStops.Any(p => p.X == block.X && p.Y == block.Y)
                && !closed.Any(p => p.NodeBlock.X == block.X && p.NodeBlock.Y == block.Y))
            {
                nearBlocks.Add(block);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var blockX = e.X / 40;
            var blockY = e.Y / 40;
           
            if (radioStart.Checked)
            {
                blockStart = new Block(blockX,blockY);
                graphics.DrawRectangle(new Pen(colorStart, 1),new Rectangle(blockX*40+5,blockY*40+5,30,30));
            }
            else if (radioEnd.Checked)
            {
                blockEnd = new Block(blockX, blockY);
                graphics.DrawRectangle(new Pen(colorEnd, 1), new Rectangle(blockX * 40 + 5, blockY * 40 + 5, 30, 30));
            }
            else
            {
                blockStops.Add( new Block(blockX, blockY));
                graphics.FillRectangle(Brushes.Gray, new Rectangle(blockX * 40 + 5, blockY * 40 + 5, 30, 30));
            }
            pictureBox1.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            blockStart = null;
            blockEnd = null;
            blockStops.Clear();
            DrawMapLines();
            pictureBox1.Refresh();
        }
    }
}
