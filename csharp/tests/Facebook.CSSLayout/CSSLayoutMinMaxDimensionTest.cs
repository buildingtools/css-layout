/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

/**
 * @Generated by gentest/gentest.sh with the following input
 *
<div id="max_width" style="width: 100px; height: 100px;">
  <div style="height: 10px; max-width: 50px;"></div>
</div>

<div id="max_height" style="width: 100px; height: 100px; flex-direction: row;">
  <div style="width: 10px; max-height: 50px;"></div>
</div>

<div id="min_height" style="width: 100px; height: 100px;">
  <div style="flex-grow: 1; min-height: 60px;"></div>
  <div style="flex-grow: 1;"></div>
</div>

<div id="min_width" style="width: 100px; height: 100px; flex-direction: row">
  <div style="flex-grow: 1; min-width: 60px;"></div>
  <div style="flex-grow: 1;"></div>
</div>

<div id="justify_content_min_max" style="max-height: 200px; min-height: 100px; width: 100px; justify-content: center;">
  <div style="width: 60px; height: 60px;"></div>
</div>

<div id="align_items_min_max" style="max-width: 200px; min-width: 100px; height: 100px; align-items: center;">
  <div style="width: 60px; height: 60px;"></div>
</div>

<div id="justify_content_overflow_min_max" style="min-height: 100px; max-height: 110px; justify-content: center;">
  <div style="width: 50px; height: 50px;"></div>
  <div style="width: 50px; height: 50px;"></div>
  <div style="width: 50px; height: 50px;"></div>
</div>

<div id="flex_grow_within_max_width" style="width: 200px; height: 100px;">
  <div style="flex-direction: row; max-width: 100px;">
    <div style="height: 20px; flex-grow: 1;"></div>
  </div>
</div>
 *
 */

using System;
using NUnit.Framework;

namespace Facebook.CSSLayout
{
    [TestFixture]
    public class CSSLayoutMinMaxDimensionTest
    {
        [Test]
        public void Test_max_width()
        {
            CSSNode root = new CSSNode();
            root.StyleWidth = 100;
            root.StyleHeight = 100;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleMaxWidth = 50;
            root_child0.StyleHeight = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(50, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(50, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(50, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_max_height()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.StyleWidth = 100;
            root.StyleHeight = 100;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 10;
            root_child0.StyleMaxHeight = 50;
            root.Insert(0, root_child0);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(50, root_child0.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(90, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(50, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_min_height()
        {
            CSSNode root = new CSSNode();
            root.StyleWidth = 100;
            root.StyleHeight = 100;

            CSSNode root_child0 = new CSSNode();
            root_child0.FlexGrow = 1;
            root_child0.StyleMinHeight = 60;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.FlexGrow = 1;
            root.Insert(1, root_child1);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(100, root_child0.LayoutWidth);
            Assert.AreEqual(80, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(80, root_child1.LayoutY);
            Assert.AreEqual(100, root_child1.LayoutWidth);
            Assert.AreEqual(20, root_child1.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(100, root_child0.LayoutWidth);
            Assert.AreEqual(80, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(80, root_child1.LayoutY);
            Assert.AreEqual(100, root_child1.LayoutWidth);
            Assert.AreEqual(20, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_min_width()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.StyleWidth = 100;
            root.StyleHeight = 100;

            CSSNode root_child0 = new CSSNode();
            root_child0.FlexGrow = 1;
            root_child0.StyleMinWidth = 60;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.FlexGrow = 1;
            root.Insert(1, root_child1);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(80, root_child0.LayoutWidth);
            Assert.AreEqual(100, root_child0.LayoutHeight);

            Assert.AreEqual(80, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(20, root_child1.LayoutWidth);
            Assert.AreEqual(100, root_child1.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(20, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(80, root_child0.LayoutWidth);
            Assert.AreEqual(100, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(20, root_child1.LayoutWidth);
            Assert.AreEqual(100, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_min_max()
        {
            CSSNode root = new CSSNode();
            root.JustifyContent = CSSJustify.Center;
            root.StyleWidth = 100;
            root.StyleMinHeight = 100;
            root.StyleMaxHeight = 200;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 60;
            root_child0.StyleHeight = 60;
            root.Insert(0, root_child0);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(20, root_child0.LayoutY);
            Assert.AreEqual(60, root_child0.LayoutWidth);
            Assert.AreEqual(60, root_child0.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(40, root_child0.LayoutX);
            Assert.AreEqual(20, root_child0.LayoutY);
            Assert.AreEqual(60, root_child0.LayoutWidth);
            Assert.AreEqual(60, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_items_min_max()
        {
            CSSNode root = new CSSNode();
            root.AlignItems = CSSAlign.Center;
            root.StyleMinWidth = 100;
            root.StyleMaxWidth = 200;
            root.StyleHeight = 100;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 60;
            root_child0.StyleHeight = 60;
            root.Insert(0, root_child0);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(20, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(60, root_child0.LayoutWidth);
            Assert.AreEqual(60, root_child0.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(100, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(20, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(60, root_child0.LayoutWidth);
            Assert.AreEqual(60, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_overflow_min_max()
        {
            CSSNode root = new CSSNode();
            root.JustifyContent = CSSJustify.Center;
            root.StyleMinHeight = 100;
            root.StyleMaxHeight = 110;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 50;
            root_child0.StyleHeight = 50;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 50;
            root_child1.StyleHeight = 50;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 50;
            root_child2.StyleHeight = 50;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(50, root.LayoutWidth);
            Assert.AreEqual(110, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(-20, root_child0.LayoutY);
            Assert.AreEqual(50, root_child0.LayoutWidth);
            Assert.AreEqual(50, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(30, root_child1.LayoutY);
            Assert.AreEqual(50, root_child1.LayoutWidth);
            Assert.AreEqual(50, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(80, root_child2.LayoutY);
            Assert.AreEqual(50, root_child2.LayoutWidth);
            Assert.AreEqual(50, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(50, root.LayoutWidth);
            Assert.AreEqual(110, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(-20, root_child0.LayoutY);
            Assert.AreEqual(50, root_child0.LayoutWidth);
            Assert.AreEqual(50, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(30, root_child1.LayoutY);
            Assert.AreEqual(50, root_child1.LayoutWidth);
            Assert.AreEqual(50, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(80, root_child2.LayoutY);
            Assert.AreEqual(50, root_child2.LayoutWidth);
            Assert.AreEqual(50, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_flex_grow_within_max_width()
        {
            CSSNode root = new CSSNode();
            root.StyleWidth = 200;
            root.StyleHeight = 100;

            CSSNode root_child0 = new CSSNode();
            root_child0.FlexDirection = CSSFlexDirection.Row;
            root_child0.StyleMaxWidth = 100;
            root.Insert(0, root_child0);

            CSSNode root_child0_child0 = new CSSNode();
            root_child0_child0.FlexGrow = 1;
            root_child0_child0.StyleHeight = 20;
            root_child0.Insert(0, root_child0_child0);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(200, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(100, root_child0.LayoutWidth);
            Assert.AreEqual(20, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child0_child0.LayoutX);
            Assert.AreEqual(0, root_child0_child0.LayoutY);
            Assert.AreEqual(100, root_child0_child0.LayoutWidth);
            Assert.AreEqual(20, root_child0_child0.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(200, root.LayoutWidth);
            Assert.AreEqual(100, root.LayoutHeight);

            Assert.AreEqual(100, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(100, root_child0.LayoutWidth);
            Assert.AreEqual(20, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child0_child0.LayoutX);
            Assert.AreEqual(0, root_child0_child0.LayoutY);
            Assert.AreEqual(100, root_child0_child0.LayoutWidth);
            Assert.AreEqual(20, root_child0_child0.LayoutHeight);
        }

    }
}
