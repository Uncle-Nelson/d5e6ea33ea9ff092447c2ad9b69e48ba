using System;
using System.Collections.Generic;
using EasyButtons;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x0200029E RID: 670
	public class Snake : TVApp
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x0003E5FB File Offset: 0x0003C7FB
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x0003E603 File Offset: 0x0003C803
		public Vector2 HeadPosition { get; private set; } = new Vector2(10f, 6f);

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x0003E60C File Offset: 0x0003C80C
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x0003E614 File Offset: 0x0003C814
		public List<Vector2> Tail { get; private set; } = new List<Vector2>();

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x0003E61D File Offset: 0x0003C81D
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x0003E625 File Offset: 0x0003C825
		public Vector2 LastTailPosition { get; private set; } = Vector2.zero;

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0003E62E File Offset: 0x0003C82E
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x0003E636 File Offset: 0x0003C836
		public Vector2 Direction { get; private set; } = Vector2.right;

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0003E63F File Offset: 0x0003C83F
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x0003E647 File Offset: 0x0003C847
		public Vector2 QueuedDirection { get; private set; } = Vector2.right;

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0003E650 File Offset: 0x0003C850
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x0003E658 File Offset: 0x0003C858
		public Vector2 NextDirection { get; private set; } = Vector2.zero;

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0003E661 File Offset: 0x0003C861
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x0003E669 File Offset: 0x0003C869
		public Snake.EGameState GameState { get; private set; }

		// Token: 0x06000DFB RID: 3579 RVA: 0x0003E672 File Offset: 0x0003C872
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0003E67C File Offset: 0x0003C87C
		private void Update()
		{
			if (base.IsPaused)
			{
				return;
			}
			if (!base.IsOpen)
			{
				return;
			}
			this.UpdateInput();
			this.UpdateMovement();
			this._timeOnGameOver += Time.deltaTime;
			this.ScoreText.text = this.Tail.Count.ToString();
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0003E6D8 File Offset: 0x0003C8D8
		private void UpdateInput()
		{
			if (this._timeOnGameOver < 0.3f)
			{
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Forward) || Input.GetKeyDown(KeyCode.UpArrow))
			{
				if (this.Direction != Vector2.down)
				{
					this.QueuedDirection = Vector2.up;
				}
				this.NextDirection = Vector2.up;
				if (this.GameState == Snake.EGameState.Ready)
				{
					this.StartGame(Vector2.up);
					return;
				}
			}
			else if (GameInput.GetButtonDown(GameInput.ButtonCode.Backward) || Input.GetKeyDown(KeyCode.DownArrow))
			{
				if (this.Direction != Vector2.up)
				{
					this.QueuedDirection = Vector2.down;
				}
				this.NextDirection = Vector2.down;
				if (this.GameState == Snake.EGameState.Ready)
				{
					this.StartGame(Vector2.down);
					return;
				}
			}
			else if (GameInput.GetButtonDown(GameInput.ButtonCode.Left) || Input.GetKeyDown(KeyCode.LeftArrow))
			{
				if (this.Direction != Vector2.right)
				{
					this.QueuedDirection = Vector2.left;
				}
				this.NextDirection = Vector2.left;
				if (this.GameState == Snake.EGameState.Ready)
				{
					this.StartGame(Vector2.left);
					return;
				}
			}
			else if (GameInput.GetButtonDown(GameInput.ButtonCode.Right) || Input.GetKeyDown(KeyCode.RightArrow))
			{
				if (this.Direction != Vector2.left)
				{
					this.QueuedDirection = Vector2.right;
				}
				this.NextDirection = Vector2.right;
				if (this.GameState == Snake.EGameState.Ready)
				{
					this.StartGame(Vector2.right);
				}
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0003E838 File Offset: 0x0003CA38
		private void UpdateMovement()
		{
			if (this.GameState != Snake.EGameState.Playing)
			{
				return;
			}
			this._timeSinceLastMove += Time.deltaTime;
			if (this._timeSinceLastMove >= this.TimePerTile)
			{
				this._timeSinceLastMove -= this.TimePerTile;
				this.MoveSnake();
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0003E888 File Offset: 0x0003CA88
		private void MoveSnake()
		{
			this.Direction = this.QueuedDirection;
			Vector2 vector = this.HeadPosition + this.Direction;
			SnakeTile tile = this.GetTile(vector);
			if (tile == null)
			{
				this.GameOver();
				return;
			}
			if (tile.Type == SnakeTile.TileType.Snake && this.Tail.Count > 0 && tile.Position != this.Tail[this.Tail.Count - 1])
			{
				this.GameOver();
				return;
			}
			bool flag = false;
			if (tile.Type == SnakeTile.TileType.Food)
			{
				this.Eat();
				flag = true;
				if (this.GameState != Snake.EGameState.Playing)
				{
					return;
				}
			}
			this.GetTile(vector).SetType(SnakeTile.TileType.Snake, 0);
			Vector2 vector2 = this.HeadPosition;
			this.HeadPosition = vector;
			for (int i = 0; i < this.Tail.Count; i++)
			{
				if (i == this.Tail.Count - 1)
				{
					this.LastTailPosition = this.Tail[i];
				}
				Vector2 vector3 = this.Tail[i];
				this.Tail[i] = vector2;
				this.GetTile(this.Tail[i]).SetType(SnakeTile.TileType.Snake, 1 + i);
				vector2 = vector3;
			}
			this.GetTile(vector2).SetType(SnakeTile.TileType.Empty, 0);
			this.LastTailPosition = vector2;
			if (this.NextDirection != Vector2.zero && this.NextDirection != -this.Direction)
			{
				this.QueuedDirection = this.NextDirection;
			}
			if (flag)
			{
				this.SpawnFood();
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0003EA14 File Offset: 0x0003CC14
		private SnakeTile GetTile(Vector2 position)
		{
			if (position.x < 0f || position.x >= 20f || position.y < 0f || position.y >= 12f)
			{
				return null;
			}
			return this.Tiles[(int)position.y * 20 + (int)position.x];
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0003EA70 File Offset: 0x0003CC70
		private void StartGame(Vector2 initialDir)
		{
			SnakeTile tile = this.GetTile(this.lastFoodPosition);
			if (tile != null)
			{
				tile.SetType(SnakeTile.TileType.Empty, 0);
			}
			this.SpawnFood();
			SnakeTile tile2 = this.GetTile(this.HeadPosition);
			if (tile2 != null)
			{
				tile2.SetType(SnakeTile.TileType.Empty, 0);
			}
			this.HeadPosition = new Vector2(10f, 6f);
			for (int i = 0; i < this.Tail.Count; i++)
			{
				this.GetTile(this.Tail[i]).SetType(SnakeTile.TileType.Empty, 0);
			}
			this.Tail.Clear();
			this.QueuedDirection = initialDir;
			this.NextDirection = Vector2.zero;
			this._timeSinceLastMove = 0f;
			this.MoveSnake();
			this.GameState = Snake.EGameState.Playing;
			if (this.onStart != null)
			{
				this.onStart.Invoke();
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0003EB46 File Offset: 0x0003CD46
		private void Eat()
		{
			this.Tail.Add(this.LastTailPosition);
			if (this.onEat != null)
			{
				this.onEat.Invoke();
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0003EB6C File Offset: 0x0003CD6C
		private void SpawnFood()
		{
			List<SnakeTile> list = new List<SnakeTile>();
			foreach (SnakeTile snakeTile in this.Tiles)
			{
				if (snakeTile.Type == SnakeTile.TileType.Empty)
				{
					list.Add(snakeTile);
				}
			}
			if (list.Count == 0)
			{
				this.Win();
				return;
			}
			SnakeTile snakeTile2 = list[Random.Range(0, list.Count)];
			snakeTile2.SetType(SnakeTile.TileType.Food, 0);
			this.lastFoodPosition = snakeTile2.Position;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0003EBE0 File Offset: 0x0003CDE0
		private void GameOver()
		{
			this.GameState = Snake.EGameState.Ready;
			this._timeOnGameOver = 0f;
			if (this.onGameOver != null)
			{
				this.onGameOver.Invoke();
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0003EC07 File Offset: 0x0003CE07
		private void Win()
		{
			this.GameState = Snake.EGameState.Ready;
			this._timeOnGameOver = 0f;
			if (this.onWin != null)
			{
				this.onWin.Invoke();
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0003EC2E File Offset: 0x0003CE2E
		protected override void TryPause()
		{
			if (this.GameState == Snake.EGameState.Ready)
			{
				this.Close();
				return;
			}
			base.TryPause();
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0003EC48 File Offset: 0x0003CE48
		[Button]
		public void CreateTiles()
		{
			SnakeTile[] tiles = this.Tiles;
			for (int i = 0; i < tiles.Length; i++)
			{
				Object.DestroyImmediate(tiles[i].gameObject);
			}
			this.Tiles = new SnakeTile[240];
			float tileSize = this.PlaySpace.rect.width / 20f;
			for (int j = 0; j < 12; j++)
			{
				for (int k = 0; k < 20; k++)
				{
					SnakeTile snakeTile = Object.Instantiate<SnakeTile>(this.TilePrefab, this.PlaySpace);
					snakeTile.SetType(SnakeTile.TileType.Empty, 0);
					snakeTile.SetPosition(new Vector2((float)k, (float)j), tileSize);
					this.Tiles[j * 20 + k] = snakeTile;
				}
			}
		}

		// Token: 0x04000EA1 RID: 3745
		public const int SIZE_X = 20;

		// Token: 0x04000EA2 RID: 3746
		public const int SIZE_Y = 12;

		// Token: 0x04000EA3 RID: 3747
		[Header("Settings")]
		public SnakeTile TilePrefab;

		// Token: 0x04000EA4 RID: 3748
		public float TimePerTile = 0.4f;

		// Token: 0x04000EA5 RID: 3749
		[Header("References")]
		public RectTransform PlaySpace;

		// Token: 0x04000EA6 RID: 3750
		public SnakeTile[] Tiles;

		// Token: 0x04000EA7 RID: 3751
		public TextMeshProUGUI ScoreText;

		// Token: 0x04000EAE RID: 3758
		private Vector2 lastFoodPosition = Vector2.zero;

		// Token: 0x04000EB0 RID: 3760
		private float _timeSinceLastMove;

		// Token: 0x04000EB1 RID: 3761
		private float _timeOnGameOver;

		// Token: 0x04000EB2 RID: 3762
		public UnityEvent onStart;

		// Token: 0x04000EB3 RID: 3763
		public UnityEvent onEat;

		// Token: 0x04000EB4 RID: 3764
		public UnityEvent onGameOver;

		// Token: 0x04000EB5 RID: 3765
		public UnityEvent onWin;

		// Token: 0x0200029F RID: 671
		public enum EGameState
		{
			// Token: 0x04000EB7 RID: 3767
			Ready,
			// Token: 0x04000EB8 RID: 3768
			Playing
		}
	}
}
